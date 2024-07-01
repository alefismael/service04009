using Service04009;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service04009;

internal class Service
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public List<Shooter> Permanences { get;  set; }
    public List<Shooter> Sentinels { get;  set; }
    public int? CommanderOfTheGuardId { get;  set; }  // Referência para o comandante da guarda que ele apontára, um comandante pode estar em vários serviços
    public Shooter? CommanderOfTheGuard { get; set; }
    public int? ServiceScaleId { get;  set; }  // Referência para o Service Scale como o EF Core aqui é muitos para muitos
    public ServiceScale? ServiceScale { get;  set; }

    // Construtor padrão da classe recebendo apenas um DateOnly (data sem horas)
    public Service(DateOnly date)
    {
        Date = date;
        Permanences = new List<Shooter>();
        Sentinels = new List<Shooter>();
        CommanderOfTheGuard = null;
    }

    // Método retorna a quantidade de atiradores necessários para o serviço
    public int GetNecessaryAmount()
    {
        return GetPermancencesNecessaryAmount() + GetSentinelsNecessaryAmount() + GetCommanderNecessaryAmount();
    }

    // Método retorna a quantidade de atiradores necessários para o serviço permanência
    public int GetPermancencesNecessaryAmount()
    {
        if ((int)Date.DayOfWeek == 0 || (int)Date.DayOfWeek > 4)
        {
            return 2 - Permanences.Count();
        }
        else
        {
            return 1 - Permanences.Count();
        }
    }

    // Método retorna a quantidade de atiradores necessários para o serviço de sentinela
    public int GetSentinelsNecessaryAmount()
    {
        return 3 - Sentinels.Count();
    }
    // Método retorna a quantidade de atiradores necessários para o serviço de comandante da guarda
    public int GetCommanderNecessaryAmount()
    {
        if (CommanderOfTheGuard == null)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }


    // Método para adicionar atirador permanência na lista interna
    public bool AddPermanence(Shooter shooter)
    {
        if ((Permanences.Count < 1) && (!shooter.isCfc) && Date.DayOfWeek >= DayOfWeek.Monday && Date.DayOfWeek <= DayOfWeek.Thursday)
        {
            Permanences.Add(shooter);
            return true;
        }
        else if (Date.DayOfWeek == DayOfWeek.Friday || Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday && (Permanences.Count < 2) && (!shooter.isCfc))
        {
            Permanences.Add(shooter);
            return true;
        }
        return false;
    }

    // Método para adicionar atirador permanência na lista interna emergência (aceita cfc)
    public bool AddPermanenceEmergency(Shooter shooter)
    {
        if ((Permanences.Count < 1) && Date.DayOfWeek >= DayOfWeek.Monday && Date.DayOfWeek <= DayOfWeek.Thursday)
        {
            Permanences.Add(shooter);
            return true;
        }
        else if (Date.DayOfWeek == DayOfWeek.Friday || Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday && (Permanences.Count < 2))
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
        if ((Sentinels.Count < 3) && (!shooter.isCfc))
        {
            Sentinels.Add(shooter);
            return true;
        }
        return false;
    }

    // Método para adicionar atirador sentinela na lista interna emergência (aceita cfc)
    public bool AddSentinelEmergency(Shooter shooter)
    {
        if (Sentinels.Count < 3)
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

    // Método para adicionar o comandante da guarda
    public bool SetCommanderOfTheGuard(Shooter shooter)
    {
        if (shooter.isCfc)
        {
            CommanderOfTheGuard = shooter;
            return true;
        }
        return false;
    }

    // Método para passar o comandante da guarda
    public Shooter? GetCommander()
    {
        if (CommanderOfTheGuard == null)
        {
            return null;
        }
        return CommanderOfTheGuard;
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

    // Método para retornar o comandante da guarda se não está ok com o serviço no dia
    public Shooter? ReturnCommanderNotOk()
    {
        if (CommanderOfTheGuard != null)
        {
            if (!CommanderOfTheGuard.IsOk(Date, 1))
            {
                return CommanderOfTheGuard;
            }

        }

        return null;
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
        if (Permanences.Contains(shooter))
        {
            return true;
        }
        else if (Sentinels.Contains(shooter))
        {
            return true;
        }
        else if (shooter.Equals(CommanderOfTheGuard))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Método para informar se já têm um comandante da guarda
    public bool HasCommanderOfTheGuard()
    {
        if (CommanderOfTheGuard != null)
        {
            return true;
        }
        return false;
    }

    // Método para ver se a escala do serviço já está completa
    public bool IsComplete()
    {
        if (Date.DayOfWeek >= DayOfWeek.Monday && Date.DayOfWeek <= DayOfWeek.Thursday)
        {
            // Segunda a quinta-feira: 1 permanência, 3 sentinelas, 1 comandante da guarda
            return Permanences.Count == 1 && Sentinels.Count == 3 && CommanderOfTheGuard != null;
        }
        else if (Date.DayOfWeek == DayOfWeek.Friday || Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
        {
            // Sexta a domingo: 2 permanências, 3 sentinelas, 1 comandante da guarda
            return Permanences.Count == 2 && Sentinels.Count == 3 && CommanderOfTheGuard != null;
        }
        else
        {
            // Outros dias: serviço não está completo
            return false;
        }
    }

    // Método para verificar se já está têm o ou os permanências que o serviço precisa
    public bool IsCompletePermanences()
    {
        if (Date.DayOfWeek >= DayOfWeek.Monday && Date.DayOfWeek <= DayOfWeek.Thursday)
        {
            // Segunda a quinta-feira: 1 permanência
            return Permanences.Count == 1;
        }
        else if (Date.DayOfWeek == DayOfWeek.Friday || Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
        {
            // Sexta a domingo: 2 permanências
            return Permanences.Count == 2;
        }
        else
        {
            return false;
        }
    }

    // Método para verificar se já está têm os sentinelas que o dia precisa
    public bool IsCompleteSentinels()
    {
        if (Sentinels.Count == 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Método ToString modificado para passar informações do serviço
    public override string ToString()
    {
        string serviceDay = Date.ToString();
        string permanencesString = string.Join(", ", Permanences.Select(s => $"{s.warName} ({s.numAtr}): {(s.IsOk(Date, 0) ? "Disponível" : "Indisponível")}, Serviços Tirados: {s.numOfService}"));
        string sentinelsString = string.Join(", ", Sentinels.Select(s => $"{s.warName} ({s.numAtr}): {(s.IsOk(Date, 1) ? "Disponível" : "Indisponível")}, Serviços Tirados: {s.numOfService}"));
        string commanderString = CommanderOfTheGuard != null ? $"{CommanderOfTheGuard.warName} ({CommanderOfTheGuard.numAtr}): {(CommanderOfTheGuard.IsOk(Date, 1) ? "Disponível" : "Indisponível")}, Serviços Tirados: {CommanderOfTheGuard.numOfService}" : "Nenhum";

        return $"Dia do Serviço: {serviceDay}\nPermanências: {permanencesString}\nSentinelas: {sentinelsString}\nComandante da Guarda: {commanderString}";
    }

}

