using Service04009;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service04009;

internal class Service
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public List<Shooter> Permanences { get; set; }
    public List<Shooter> Sentinels { get; set; }
    public List<Shooter> Commanders { get; set; }
    public int? ServiceScaleId { get; set; }
    public ServiceScale? ServiceScale { get; set; }

    // Referência à configuração vigente (injetada na criação da escala)
    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    private ServiceConfig? _config;

    public Service() { }

    // Construtor padrão recebendo data e configuração
    public Service(DateOnly date, ServiceConfig? config = null)
    {
        Date = date;
        Permanences = new List<Shooter>();
        Sentinels = new List<Shooter>();
        Commanders = new List<Shooter>();
        _config = config;
    }

    /// <summary>Define a configuração deste serviço (usado ao carregar do banco).</summary>
    public void SetConfig(ServiceConfig config) => _config = config;

    // ── Helpers de configuração ──

    private int MaxPermanences => _config?.GetPermanences(Date.DayOfWeek) ?? DefaultMaxPermanences();
    private int MaxSentinels => _config?.GetSentinels(Date.DayOfWeek) ?? 3;
    private int MaxCommanders => _config?.GetCommanders(Date.DayOfWeek) ?? 1;
    private bool CommanderMustBeCfc => _config?.MustCommanderBeCfc(Date.DayOfWeek) ?? true;

    private int DefaultMaxPermanences()
    {
        if (Date.DayOfWeek == DayOfWeek.Sunday || (int)Date.DayOfWeek > 4)
            return 2;
        return 1;
    }

    // Método retorna a quantidade de atiradores necessários para o serviço
    public int GetNecessaryAmount()
    {
        return GetPermancencesNecessaryAmount() + GetSentinelsNecessaryAmount() + GetCommanderNecessaryAmount();
    }

    public int GetPermancencesNecessaryAmount()
    {
        return MaxPermanences - Permanences.Count;
    }

    public int GetSentinelsNecessaryAmount()
    {
        return MaxSentinels - Sentinels.Count;
    }

    public int GetCommanderNecessaryAmount()
    {
        return Math.Max(0, MaxCommanders - Commanders.Count);
    }

    // Método para adicionar atirador permanência (respeita config)
    public bool AddPermanence(Shooter shooter)
    {
        if (Permanences.Count < MaxPermanences && !shooter.isCfc)
        {
            Permanences.Add(shooter);
            return true;
        }
        return false;
    }

    // Método para adicionar atirador permanência por troca (aceita cfc)
    public bool AddPermanenceSwap(Shooter shooter)
    {
        if (Permanences.Count < MaxPermanences)
        {
            Permanences.Add(shooter);
            return true;
        }
        return false;
    }

    // Método para remover atirador permanência na lista interna
    public bool RemovePermanence(Shooter shooter)
    {
        if (Permanences.Contains(shooter))
        {
            Permanences.Remove(shooter);
            return true;
        }
        return false;
    }

    // Método para adicionar atirador sentinela na lista interna
    public bool AddSentinel(Shooter shooter)
    {
        if (Sentinels.Count < MaxSentinels && !shooter.isCfc)
        {
            Sentinels.Add(shooter);
            return true;
        }
        return false;
    }

    // Método para adicionar atirador sentinela na lista interna por troca (aceita cfc)
    public bool AddSentinelSwap(Shooter shooter)
    {
        if (Sentinels.Count < MaxSentinels)
        {
            Sentinels.Add(shooter);
            return true;
        }
        return false;
    }

    // Método para remover atirador sentinela na lista interna
    public bool RemoveSentinel(Shooter shooter)
    {
        if (Sentinels.Contains(shooter))
        {
            Sentinels.Remove(shooter);
            return true;
        }
        return false;
    }

    // Método para adicionar um comandante da guarda (respeita config de CFC obrigatório e MaxCommanders)
    public bool AddCommander(Shooter shooter)
    {
        if (Commanders.Count >= MaxCommanders)
            return false;
        if (CommanderMustBeCfc && !shooter.isCfc)
            return false;

        Commanders.Add(shooter);
        return true;
    }

    // Método para adicionar comandante por troca (aceita não cfc)
    public bool AddCommanderSwap(Shooter shooter)
    {
        if (Commanders.Count >= MaxCommanders)
            return false;
        Commanders.Add(shooter);
        return true;
    }

    // Método para remover um comandante da lista
    public bool RemoveCommander(Shooter shooter)
    {
        return Commanders.Remove(shooter);
    }

    // Método para passar o primeiro comandante da guarda (compatibilidade)
    public Shooter? GetCommander()
    {
        return Commanders.Count > 0 ? Commanders[0] : null;
    }

    // Método para passar todos os comandantes
    public List<Shooter> GetCommanders()
    {
        return Commanders;
    }

    // Método para passar os permanências da guarda
    public List<Shooter> GetPermanences()
    {
        return Permanences;
    }

    // Método para passar os sentinelas da guarda
    public List<Shooter> GetSentinels()
    {
        return Sentinels;
    }

    // Método para passar adicionar quantidade de serviços dos atiradores nesse serviço
    public void AddShooterNumberService()
    {
        foreach (var shooter in Permanences)
        {
            shooter.AddNumService();
        }
        foreach (var shooter in Sentinels)
        {
            shooter.AddNumService();
        }
        foreach (var shooter in Commanders)
        {
            shooter.AddNumService();
        }
    }

    // Método para passar subtrair quantidade de serviços dos atiradores nesse serviço
    public void SubtractShooterNumberService()
    {
        foreach (var shooter in Permanences)
        {
            shooter.SubtractNumService();
        }
        foreach (var shooter in Sentinels)
        {
            shooter.SubtractNumService();
        }
        foreach (var shooter in Commanders)
        {
            shooter.SubtractNumService();
        }
    }

    // Método para retornar os comandantes da guarda que não estão ok com o serviço no dia
    public List<Shooter> ReturnCommandersNotOk()
    {
        var notOk = new List<Shooter>();
        foreach (var cmd in Commanders)
        {
            if (!cmd.IsOk(Date, 1))
                notOk.Add(cmd);
        }
        return notOk;
    }

    // Método para retornar os permanências que não estão ok com o serviço no dia
    public List<Shooter> ReturnPermancesNotOk()
    {
        List<Shooter> permaNotOk = new List<Shooter>();
        foreach (var shot in Permanences)
        {
            if (!shot.IsOk(Date, 0))
            {
                permaNotOk.Add(shot);
            }
        }
        return permaNotOk;
    }

    // Método para retornar os sentinelas que não estão ok com o serviço no dia
    public List<Shooter> ReturnSentinelsNotOk()
    {
        List<Shooter> sentilNotOk = new List<Shooter>();
        foreach (var shot in Sentinels)
        {
            if (!shot.IsOk(Date, 1))
            {
                sentilNotOk.Add(shot);
            }
        }
        return sentilNotOk;
    }

    // Método para informar com um bool se o atirador passado está nesse serviço
    public bool HasShooter(Shooter shooter)
    {
        return Permanences.Contains(shooter)
            || Sentinels.Contains(shooter)
            || Commanders.Contains(shooter);
    }

    // Método para ver se a escala do serviço já está completa
    public bool IsComplete()
    {
        return Permanences.Count >= MaxPermanences
            && Sentinels.Count >= MaxSentinels
            && Commanders.Count >= MaxCommanders;
    }

    // Método para verificar se já tem os permanências que o serviço precisa
    public bool IsCompletePermanences()
    {
        return Permanences.Count >= MaxPermanences;
    }

    // Método para verificar se já tem os sentinelas que o dia precisa
    public bool IsCompleteSentinels()
    {
        return Sentinels.Count >= MaxSentinels;
    }

    // Método retorna 0 se o atirador não está no serviço, 1 se é permanência na lista, 2 se é sentinela e 3 se é comandante da guarda
    public int ShowShooterFunctionInScale(Shooter shooter)
    {
        if (Permanences.Contains(shooter))
            return 1;
        if (Sentinels.Contains(shooter))
            return 2;
        if (Commanders.Contains(shooter))
            return 3;
        return 0;
    }

    // Método ToString modificado para passar informações do serviço
    public override string ToString()
    {
        string serviceDay = Date.ToString();
        string permanencesString = string.Join(", ", Permanences.Select(s => $"{s.warName} ({s.numAtr}): {(s.IsOk(Date, 0) ? "Disponível" : "Indisponível")}, Serviços Tirados: {s.numOfService}"));
        string sentinelsString = string.Join(", ", Sentinels.Select(s => $"{s.warName} ({s.numAtr}): {(s.IsOk(Date, 1) ? "Disponível" : "Indisponível")}, Serviços Tirados: {s.numOfService}"));
        string commanderString = Commanders.Count > 0
            ? string.Join(", ", Commanders.Select(c => $"{c.warName} ({c.numAtr}): {(c.IsOk(Date, 1) ? "Disponível" : "Indisponível")}, Serviços Tirados: {c.numOfService}"))
            : "Nenhum";

        return $"Dia do Serviço: {serviceDay}\nPermanências: {permanencesString}\nSentinelas: {sentinelsString}\nComandante(s) da Guarda: {commanderString}";
    }

}

