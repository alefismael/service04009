using Service04009;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Service04009;

internal class ServiceScale
{
    public int id { get; private set; }
    public DateOnly firstDay { get; private set; }
    public DateOnly lastDay { get; private set; }
    public List<Service> Services { get; private set; }

    //A classe é criada passando o dia do primeiro serviço
    public ServiceScale(DateOnly firstDay, int numServices)
    {
        this.firstDay = firstDay;
        Services = new List<Service>();

        // Cria serviços com base no primeiro dia da escala e a quantidade passada
        for (int i = 0; i < numServices; i++)
        {
            Services.Add(new Service(firstDay.AddDays(i)));
        }
        lastDay = firstDay;
    }

    // Método para definir a escala de serviço
    public List<Shooter> DefineScale(List<Shooter> shooters)
    {
        shooters.Sort();
        List<Shooter> cfcShooters = shooters.Where(s => s.isCfc).ToList(); // Lista dos Cfc
        cfcShooters.Sort();  // Ordeno os cfc (menor quantidade de serviços para maior)
        int minServicesCfc = cfcShooters[0].CountService();  //Pego o menor número que um dos cfc tirou de serviço
        List<Shooter> notCfcShooters = shooters.Where(s => !s.isCfc).ToList();  // Lista dos que não são Cfc
        notCfcShooters.Sort();  // Ordeno os que não são do cfc
        int minServices = notCfcShooters[0].CountService();  //Pego o menor número que um dos que não são cfc tirou de serviço

        // Aqui faço o algoritmo para selecionar os comandantes da guarda de cada dia (só pode cfc) enquanto não está completo

        while (!IsCompleteCommanders())
        {
            // Vai serviço a serviço tentando atribuir a eles os atiradores disponíveis
            foreach (var service in Services)
            {
                List<Shooter> commandersOK = new List<Shooter>();  // Lista para pegar os cfcs disponíveis para a data
                foreach (var cfcShooter in cfcShooters)
                {

                    if (cfcShooter.IsOk(service.Date, 1) && !HasInScale(cfcShooter) && cfcShooter.CountService() == minServicesCfc && !service.HasCommanderOfTheGuard()) // Se o cfc pode na data, ainda não foi escalado, não tem comandante da guarda no serviço ainda e o cfc está com o número de serviços tirados igual o menor número
                    {
                        commandersOK.Add(cfcShooter);
                    }
                }
                if (commandersOK.Count() != 0)  // Se têm cfcs disponíveis para a data, entra no if e seleciona um deles para o serviço de maneira aleatória
                {
                    service.SetCommanderOfTheGuard(GetRandomShooter(commandersOK));
                }
            }

            // Se mesmo tentando os cfcs que podem na data não está completa a escala de comandantes aí pega os que não estão na escala mas têm a menor quantidade de serviços tirados
            if (!IsCompleteCommanders())
            {
                foreach (var service in Services)
                {
                    List<Shooter> commanders = new List<Shooter>();
                    foreach (var cfcShooter in cfcShooters)
                    {
                        if (!HasInScale(cfcShooter) && cfcShooter.CountService() == minServicesCfc && !service.HasCommanderOfTheGuard()) // Se não esrá na escala, tirou a menor quantidade de serviços até aqui e não têm comandante da guarda no serviço ainda então coloca ele na lista para sorteio do comandante da guarda desse dia
                        {
                            commanders.Add(cfcShooter);
                            break;
                        }
                    }
                    if (commanders.Count() != 0)
                    {
                        service.SetCommanderOfTheGuard(GetRandomShooter(commanders));
                    }
                }
            }
            minServicesCfc++;
        }

        // Método para definir os sentinelas e permanências de todos serviços da escala
        while (!IsCompleteSentinels() || !IsCompletePermanences())
        {
            int aux = 0;  // Esse aux serve para ajudar a determinar a quantidade do loop for
            foreach (var service in Services)
            {
                List<Shooter> shootersOkPermanences = new List<Shooter>();  // Lista para adicionar quem pode ser permanência nesse dia para poder ser selecionado
                List<Shooter> shootersOkSentinels = new List<Shooter>();// Lista para adicionar quem pode ser sentinela nesse dia para poder ser selecionado
                foreach (var shooter in notCfcShooters)
                {

                    if (shooter.IsOk(service.Date, 0) && !HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompletePermanences())  //Se o atirador pode no dia como permanência, não está em um serviço da escala e tirou a menor quantidade de serviços e o serviço não está completo adiciona ele como uma possibilidade para o serviço de permanência
                    {
                        shootersOkPermanences.Add(shooter);
                    }
                    if (shooter.IsOk(service.Date, 1) && !HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompleteSentinels())//Se o atirador pode no dia como sentinela, não está em um serviço da escala e tirou a menor quantidade de serviços e o serviço não está completo adiciona ele como uma possibilidade para o serviço de sentinela
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

                        if (!HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompletePermanences())
                        {
                            shootersPermanences.Add(shooter);
                        }
                        if (!HasInScale(shooter) && shooter.CountService() == minServices && !service.IsCompleteSentinels())
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
            Shooter? commander = service.ReturnCommanderNotOk();  // Pega o comandante da guarda de serviço se ele estiver escalado mesmo não podendo para tentar a troca
            List<Shooter> permanencesNotOK = service.ReturnPermancesNotOk();// Pega os permanências da guarda de serviço se eles estiverem escalados mesmo não podendo para tentar a troca
            List<Shooter> sentinelsNotOK = service.ReturnSentinelsNotOk();// Pega os sentinelas da guarda de serviço se eles estiverem escalados mesmo não podendo para tentar a troca

            if (commander != null)  //Se têm o comandante que não está ok com o dia que pegou serviço
            {
                bool ultimoRecurso = true;  // ultimoRecurso no if final se necessário caso não encontre alguém para troca de serviço
                foreach (var serviceSwap in Services)
                {
                    if (commander.IsOk(serviceSwap.Date, 1)) // Se o commander pode pegar serviço na data do outro serviço da escala
                    {
                        var codSwap = serviceSwap.GetCommander();  // Pega o comandante da guarda do outro serviço
                        if (codSwap != null && codSwap.IsOk(service.Date, 1))  // Se o comandante da guarda do outro serviço pode tirar o serviço no lugar do comandante que não pode
                        {
                            // Faz a troca de serviço
                            if (service.SetCommanderOfTheGuard(codSwap))
                            {
                                serviceSwap.SetCommanderOfTheGuard(commander);
                                ultimoRecurso = false;
                                break;
                            }
                        }
                    }
                }
                if (ultimoRecurso)  // Se a troca não foi feita esse é o último recurso
                {
                    // Pega todos os atirados cfc um a um
                    foreach (var codSwap in cfcShooters)
                    {
                        // Se não está na escala e realmente é cfc
                        if (codSwap.isCfc && !HasInScale(codSwap))
                        {
                            if (codSwap.IsOk(service.Date, 1) && (codSwap.CountService() <= commander.CountService()))  // Se este atirador tirou a mesma quantidade de serviços que o outro e pode na data faz a troca
                            {
                                service.SetCommanderOfTheGuard(codSwap);
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
                            if (shooterSwap.IsOk(service.Date, 0) && (shooterSwap.CountService() <= shooter.CountService()))
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
                            if (shooterSwap.IsOk(service.Date, 1) && (shooterSwap.CountService() <= shooter.CountService()))
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
        return shooters[new Random().Next(shooters.Count)];
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

    // Método auxiliar para verificar se todos os serviços têm os comandantes
    public bool IsCompleteCommanders()
    {
        foreach (var service in Services)
        {
            if (!service.HasCommanderOfTheGuard())
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

}
