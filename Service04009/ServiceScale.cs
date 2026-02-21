using Service04009;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service04009;

internal class ServiceScale
{
    private static readonly Random _random = new Random();

    public int id { get; set; }
    public DateOnly firstDay { get; private set; }
    public DateOnly lastDay { get; private set; }
    public List<Service> Services { get; private set; }

    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    private ServiceConfig? _config;

    public ServiceScale() { }

    //A classe é criada passando o dia do primeiro serviço e fim, com configuração opcional
    public ServiceScale(DateOnly firstDay, DateOnly lastDay, ServiceConfig? config = null)
    {
        Services = new List<Service>();
        this.firstDay = firstDay;
        this.lastDay = lastDay;
        _config = config;
        int numServices = lastDay.DayNumber - firstDay.DayNumber + 1;

        for (int i = 0; i < numServices; i++)
        {
            Services.Add(new Service(firstDay.AddDays(i), config));
        }
    }

    /// <summary>Injeta config em todos os serviços (útil ao carregar do banco).</summary>
    public void SetConfig(ServiceConfig config)
    {
        _config = config;
        if (Services != null)
        {
            foreach (var svc in Services)
                svc.SetConfig(config);
        }
    }

    // Método para definir a escala de serviço
    public List<Shooter> DefineScale(List<Shooter> shooters)
    {
        shooters.Sort();

        List<Shooter> cfcShooters = shooters.Where(s => s.isCfc).ToList();
        cfcShooters.Sort();
        List<Shooter> notCfcShooters = shooters.Where(s => !s.isCfc).ToList();
        notCfcShooters.Sort();

        // ── Fase 1: Atribuir Comandantes da Guarda ──

        // Fase 1a: Primeiro atribuir atiradores CFC como comandantes
        // (necessário para dias que exigem CFC, mas aceito em qualquer dia)
        if (cfcShooters.Count > 0)
        {
            int minServicesCfc = cfcShooters[0].numOfService;
            int safetyLimit = cfcShooters.Max(s => s.numOfService) + 2;

            while (!IsCompleteCommanders() && minServicesCfc <= safetyLimit)
            {
                foreach (var service in Services)
                {
                    if (service.GetCommanderNecessaryAmount() == 0)
                        continue;

                    List<Shooter> commandersOK = new List<Shooter>();
                    foreach (var cfcShooter in cfcShooters)
                    {
                        if (cfcShooter.IsOk(service.Date, 1) && !HasInScale(cfcShooter)
                            && cfcShooter.numOfService == minServicesCfc)
                        {
                            commandersOK.Add(cfcShooter);
                        }
                    }
                    while (commandersOK.Count > 0 && service.GetCommanderNecessaryAmount() > 0)
                    {
                        var chosen = GetRandomShooter(commandersOK);
                        service.AddCommander(chosen);
                        commandersOK.Remove(chosen);
                    }
                }

                if (!IsCompleteCommanders())
                {
                    foreach (var service in Services)
                    {
                        if (service.GetCommanderNecessaryAmount() == 0)
                            continue;

                        foreach (var cfcShooter in cfcShooters)
                        {
                            if (!HasInScale(cfcShooter) && cfcShooter.numOfService == minServicesCfc)
                            {
                                if (service.AddCommander(cfcShooter))
                                    break;
                            }
                        }
                    }
                }
                minServicesCfc++;
            }
        }

        // Fase 1b: Para dias que ainda precisam de comandante (CFC não obrigatório
        // nesse dia, ou CFC insuficientes) — qualquer atirador disponível
        if (!IsCompleteCommanders() && shooters.Count > 0)
        {
            int minSvc = shooters.Where(s => !HasInScale(s)).DefaultIfEmpty(shooters[0]).Min(s => s.numOfService);
            int safetyLimit = shooters.Max(s => s.numOfService) + 2;

            while (!IsCompleteCommanders() && minSvc <= safetyLimit)
            {
                foreach (var service in Services)
                {
                    if (service.GetCommanderNecessaryAmount() == 0)
                        continue;

                    var candidates = shooters.Where(s =>
                        s.IsOk(service.Date, 1) && !HasInScale(s) && s.numOfService == minSvc).ToList();
                    while (candidates.Count > 0 && service.GetCommanderNecessaryAmount() > 0)
                    {
                        var chosen = GetRandomShooter(candidates);
                        service.AddCommander(chosen);
                        candidates.Remove(chosen);
                    }
                }

                if (!IsCompleteCommanders())
                {
                    foreach (var service in Services)
                    {
                        if (service.GetCommanderNecessaryAmount() == 0)
                            continue;

                        var candidates = shooters.Where(s =>
                            !HasInScale(s) && s.numOfService == minSvc).ToList();
                        while (candidates.Count > 0 && service.GetCommanderNecessaryAmount() > 0)
                        {
                            var chosen = GetRandomShooter(candidates);
                            service.AddCommander(chosen);
                            candidates.Remove(chosen);
                        }
                    }
                }
                minSvc++;
            }
        }

        // ── Fase 2: Permanências e Sentinelas ──
        int minServices = notCfcShooters.Count > 0 ? notCfcShooters[0].numOfService : 0;

        while (!IsCompleteSentinels() || !IsCompletePermanences())
        {
            int aux = 0;  // Esse aux serve para ajudar a determinar a quantidade do loop for
            foreach (var service in Services)
            {
                List<Shooter> shootersOkPermanences = new List<Shooter>();  // Lista para adicionar quem pode ser permanência nesse dia para poder ser selecionado
                List<Shooter> shootersOkSentinels = new List<Shooter>();// Lista para adicionar quem pode ser sentinela nesse dia para poder ser selecionado
                foreach (var shooter in notCfcShooters)
                {

                    if (shooter.IsOk(service.Date, 0) && !HasInScale(shooter) && shooter.numOfService == minServices && !service.IsCompletePermanences())  //Se o atirador pode no dia como permanência, não está em um serviço da escala e tirou a menor quantidade de serviços e o serviço não está completo adiciona ele como uma possibilidade para o serviço de permanência
                    {
                        shootersOkPermanences.Add(shooter);
                    }
                    if (shooter.IsOk(service.Date, 1) && !HasInScale(shooter) && shooter.numOfService == minServices && !service.IsCompleteSentinels())//Se o atirador pode no dia como sentinela, não está em um serviço da escala e tirou a menor quantidade de serviços e o serviço não está completo adiciona ele como uma possibilidade para o serviço de sentinela
                    {
                        shootersOkSentinels.Add(shooter);
                    }
                }

                aux = service.GetPermancencesNecessaryAmount();  // Pega a quantidade de permanências que o serviço precisa, no caso 0, 1 ou 2
                for (int i = 0; i < aux; i++)
                {
                    // Se têm atiradores disponíveis para o serviço de permanência
                    if (shootersOkPermanences.Count() != 0)
                    {
                        var shot = GetRandomShooter(shootersOkPermanences); // Seleciona um aleatório
                        service.AddPermanence(shot);  // Adiciona ele no serviço
                        notCfcShooters.Remove(shot);  // Remove da lista de quem não é cfc para ele não ficar sendo chamado nas verificações como já foi escalado ( isso melhora a velocidade do algoritmo
                        shootersOkPermanences.Remove(shot);  // Remove ele de possibilidade para esse serviço de permanência já que foi selecionado já para não repetir
                        shootersOkSentinels.Remove(shot);  // Remove ele de possibilidade para esse serviço de sentinela já que foi selecionado já para não repetir
                    }
                }

                // Praticamente a mesma lógica de cima
                aux = service.GetSentinelsNecessaryAmount();
                for (int i = 0; i < aux; i++)
                {
                    if (shootersOkSentinels.Count() != 0)
                    {
                        var shot = GetRandomShooter(shootersOkSentinels);
                        service.AddSentinel(shot);
                        notCfcShooters.Remove(shot);
                        shootersOkSentinels.Remove(shot);
                    }
                }

            }

            // Se mesmo tentando da melhor maneira o serviço de permanência ou sentinela ainda não está completo
            if (!IsCompleteSentinels() || !IsCompletePermanences())
            {
                foreach (var service in Services)
                {
                    List<Shooter> shootersPermanences = new List<Shooter>();
                    List<Shooter> shootersSentinels = new List<Shooter>();
                    foreach (var shooter in notCfcShooters)
                    {
                        // Aqui pega quem ainda não está escalado que tirou poucos serviços, isso levando em conta se o serviço ainda precisa de atiradores sendo observado com IsComplete

                        if (!HasInScale(shooter) && shooter.numOfService == minServices && !service.IsCompletePermanences())
                        {
                            shootersPermanences.Add(shooter);
                        }
                        if (!HasInScale(shooter) && shooter.numOfService == minServices && !service.IsCompleteSentinels())
                        {
                            shootersSentinels.Add(shooter);
                        }
                    }

                    aux = service.GetPermancencesNecessaryAmount();
                    for (int i = 0; i < aux; i++)
                    {
                        if (shootersPermanences.Count() != 0)
                        {
                            var shot = GetRandomShooter(shootersPermanences);
                            service.AddPermanence(shot);
                            notCfcShooters.Remove(shot);
                            shootersPermanences.Remove(shot);
                            shootersSentinels.Remove(shot);
                        }
                    }

                    aux = service.GetSentinelsNecessaryAmount();
                    for (int i = 0; i < aux; i++)
                    {
                        if (shootersSentinels.Count() != 0)
                        {
                            var shot = GetRandomShooter(shootersSentinels);
                            notCfcShooters.Remove(shot);
                            service.AddSentinel(shot);
                            shootersSentinels.Remove(shot);
                        }
                    }
                }
            }
            minServices++;  // Aumenta a quantidade de serviços tirados para pegar mais atiradores se necessário para completar a escala
        }

        // Aqui depois que a escala estiver completa é verificado se têm atiradores que não podem estar em algum dia mas estão
        // Se houver é tentado realizar a troca dele com outro atirador se possível for
        foreach (var service in Services)
        {
            List<Shooter> commandersNotOK = service.ReturnCommandersNotOk();  // Pega os comandantes que não podem no dia
            List<Shooter> permanencesNotOK = service.ReturnPermancesNotOk();
            List<Shooter> sentinelsNotOK = service.ReturnSentinelsNotOk();

            // Troca para cada comandante que não está ok
            foreach (var commander in commandersNotOK)
            {
                bool ultimoRecurso = true;
                bool swapped = false;
                foreach (var serviceSwap in Services)
                {
                    if (swapped) break;
                    if (commander.IsOk(serviceSwap.Date, 1))
                    {
                        // Tenta trocar com um comandante do outro dia
                        foreach (var codSwap in serviceSwap.GetCommanders().ToList())
                        {
                            if (codSwap.IsOk(service.Date, 1))
                            {
                                service.RemoveCommander(commander);
                                serviceSwap.RemoveCommander(codSwap);
                                service.AddCommander(codSwap);
                                serviceSwap.AddCommander(commander);
                                ultimoRecurso = false;
                                swapped = true;
                                break;
                            }
                        }
                    }
                }
                if (ultimoRecurso)
                {
                    foreach (var codSwap in cfcShooters)
                    {
                        if (codSwap.isCfc && !HasInScale(codSwap))
                        {
                            if (codSwap.IsOk(service.Date, 1) && (codSwap.numOfService <= commander.numOfService))
                            {
                                service.RemoveCommander(commander);
                                service.AddCommander(codSwap);
                                break;
                            }
                        }
                    }
                }
            }

            // Troca para os permanências do serviço que não pode na data do serviço se existir
            foreach (var shooter in permanencesNotOK)
            {
                bool ultimoRecurso = true;  // ultimoRecurso no if final se necessário caso não encontre alguém para troca de serviço
                bool aux = false;  // aux para parar o foreach se o atirador já foi trocado para não precisar ficar passando de serviço em serviço usando o break dentro de um if(aux)
                foreach (var serviceSwap in Services)
                {
                    List<Shooter> permanencesSwap = serviceSwap.GetPermanences();
                    // Tenta alguém que pode trocar de serviço para fazer a troca(mesma lógica praticamente da do commander
                    foreach (var permaSwap in permanencesSwap)
                    {
                        if (shooter.IsOk(serviceSwap.Date, 0) && permaSwap.IsOk(service.Date, 0))
                        {
                            if (service.RemovePermanence(shooter) && serviceSwap.RemovePermanence(permaSwap))
                            {
                                service.AddPermanence(permaSwap);
                                serviceSwap.AddPermanence(shooter);
                                aux = true;
                                ultimoRecurso = false;
                                break;
                            }
                        }
                    }
                    if (aux)
                    {
                        break;
                    }
                    else
                    {
                        List<Shooter> sentinelSwap = serviceSwap.GetSentinels();
                        // Tenta alguém que pode trocar de serviço para fazer a troca(mesma lógica praticamente da do commander
                        foreach (var sentilSwap in sentinelSwap)
                        {
                            if (shooter.IsOk(serviceSwap.Date, 1) && sentilSwap.IsOk(service.Date, 0))
                            {
                                if (service.RemovePermanence(shooter) && serviceSwap.RemoveSentinel(sentilSwap))
                                {
                                    service.AddPermanence(sentilSwap);
                                    serviceSwap.AddSentinel(shooter);
                                    aux = true;
                                    ultimoRecurso = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (aux)
                    {
                        break;
                    }
                }

                if (ultimoRecurso)
                {
                    foreach (var shooterSwap in shooters)
                    {
                        if (!shooterSwap.isCfc && !HasInScale(shooterSwap))
                        {
                            if (shooterSwap.IsOk(service.Date, 0) && (shooterSwap.numOfService <= shooter.numOfService))
                            {
                                service.RemovePermanence(shooter);
                                service.AddPermanence(shooterSwap);
                                break;
                            }
                        }
                    }
                }

            }

            // Troca para os sentinelas do serviço que não pode na data do serviço se existir
            foreach (var shooter in sentinelsNotOK)
            {
                bool ultimoRecurso = true;  // ultimoRecurso no if final se necessário caso não encontre alguém para troca de serviço
                bool aux = false;
                foreach (var serviceSwap in Services)
                {
                    List<Shooter> permanencesSwap = serviceSwap.GetPermanences();
                    foreach (var permaSwap in permanencesSwap)
                    {
                        if (shooter.IsOk(serviceSwap.Date, 0) && permaSwap.IsOk(service.Date, 1))
                        {
                            if (service.RemoveSentinel(shooter) && serviceSwap.RemovePermanence(permaSwap))
                            {
                                service.AddSentinel(permaSwap);
                                serviceSwap.AddPermanence(shooter);
                                aux = true;
                                ultimoRecurso = false;
                                break;
                            }
                        }
                    }
                    if (aux)
                    {
                        break;
                    }
                    else
                    {
                        List<Shooter> sentinelSwap = serviceSwap.GetSentinels();
                        foreach (var sentilSwap in sentinelSwap)
                        {
                            if (shooter.IsOk(serviceSwap.Date, 1) && sentilSwap.IsOk(service.Date, 1))
                            {
                                if (service.RemoveSentinel(shooter) && serviceSwap.RemoveSentinel(sentilSwap))
                                {
                                    service.AddSentinel(sentilSwap);
                                    serviceSwap.AddSentinel(shooter);
                                    aux = true;
                                    ultimoRecurso = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (aux)
                    {
                        break;
                    }
                }

                if (ultimoRecurso)
                {
                    foreach (var shooterSwap in shooters)
                    {
                        if (!shooterSwap.isCfc && !HasInScale(shooterSwap))
                        {
                            if (shooterSwap.IsOk(service.Date, 1) && (shooterSwap.numOfService <= shooter.numOfService))
                            {
                                service.RemoveSentinel(shooter);
                                service.AddSentinel(shooterSwap);
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Foreach para adicionar um serviço nos dados dos atiradores que estão na escala de serviço
        foreach (var shooter in shooters)
        {
            if (HasInScale(shooter))
            {
                shooter.AddNumService();
            }
        }
        return shooters;
    }

    // Método auxiliar para verificar se um atirador já está em um dos serviços da escala
    private bool HasInScale(Shooter shooter)
    {
        foreach (var service in Services)
        {
            if (service.HasShooter(shooter))
            {
                return true;
            }
        }
        return false;
    }

    // Método auxiliar para sortear um atirador aleatório
    private Shooter GetRandomShooter(List<Shooter> shooters)
    {
        return shooters[_random.Next(shooters.Count)];
    }

    // Verifica se todos os serviços estão completos
    public bool IsComplete()
    {
        foreach (var service in Services)
        {
            if (!service.IsComplete())
            {
                return false;
            }
        }
        return true;
    }

    // Método auxiliar para verificar se todos os serviços têm os comandantes necessários
    public bool IsCompleteCommanders()
    {
        foreach (var service in Services)
        {
            if (service.GetCommanderNecessaryAmount() > 0)
            {
                return false;
            }
        }
        return true;
    }

    // Método auxiliar para verificar se todos os serviços têm os sentinelas necessários
    public bool IsCompleteSentinels()
    {
        foreach (var service in Services)
        {
            if (!service.IsCompleteSentinels())
            {
                return false;
            }
        }
        return true;
    }

    // Método auxiliar para verificar se todos os serviços têm os permanências necessários
    public bool IsCompletePermanences()
    {
        foreach (var service in Services)
        {
            if (!service.IsCompletePermanences())
            {
                return false;
            }
        }
        return true;
    }

    // Método static para saber quantos cfcs precisam (usa config se disponível)
    public static int GetNecessaryCfcForScale(DateOnly startDate, DateOnly endDate, ServiceConfig? config = null)
    {
        int necessary = 0;
        int diference = endDate.DayNumber - startDate.DayNumber;
        var dt = startDate;

        for (int i = 0; i <= diference; i++)
        {
            int commanders = config?.GetCommanders(dt.DayOfWeek) ?? 1;
            bool mustBeCfc = config?.MustCommanderBeCfc(dt.DayOfWeek) ?? true;
            if (mustBeCfc)
                necessary += commanders;
            dt = dt.AddDays(1);
        }

        return necessary;
    }

    // Método static para saber quantos atiradores não cfc precisam (usa config se disponível)
    public static int GetNecessaryShootersNotSfcForScale(DateOnly startDate, DateOnly endDate, ServiceConfig? config = null)
    {
        int necessary = 0;
        int diference = endDate.DayNumber - startDate.DayNumber;
        var dt = startDate;

        for (int i = 0; i <= diference; i++)
        {
            int sentinels = config?.GetSentinels(dt.DayOfWeek) ?? 3;
            int permanences = config?.GetPermanences(dt.DayOfWeek) ?? (dt.DayOfWeek == DayOfWeek.Sunday || (int)dt.DayOfWeek > 4 ? 2 : 1);
            necessary += sentinels + permanences;
            dt = dt.AddDays(1);
        }

        return necessary;
    }

    // Método ToString para passar informações extras
    public override string ToString()
    {
        if (IsComplete())
        {
            DateOnly firstDay = Services.First().Date;
            DateOnly lastDay = Services.Last().Date;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"A escala de serviço do dia {firstDay:dd/MM/yyyy} até o dia {lastDay:dd/MM/yyyy} é:");

            foreach (var service in Services)
            {
                stringBuilder.AppendLine(service.ToString());
            }

            return stringBuilder.ToString();
        }
        else
        {
            return "A escala não está completa.";
        }
    }

    // Retorna a quantidade de serviços da escala
    public int CountDaysService()
    {
        return Services.Count();
    }

    public bool subtractNumberOfServicesFromAllShootersOnTheScale()
    {
        foreach (var service in Services)
        {
            service.SubtractShooterNumberService();
        }

        return true;
    }

}
