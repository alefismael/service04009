using System.ComponentModel.DataAnnotations;

namespace Service04009;

/// <summary>
/// Configuração parametrizável de um serviço.
/// Define quantos atiradores de cada função são necessários por dia da semana,
/// e se CFC é obrigatório para o comandante da guarda nesse dia.
/// Cada dia da semana tem sua própria configuração individual.
/// </summary>
public class ServiceConfig
{
    [Key]
    public int Id { get; set; }

    // ── Domingo ──
    public int SundayPermanences { get; set; } = 2;
    public int SundaySentinels { get; set; } = 3;
    public int SundayCommanders { get; set; } = 1;
    public bool SundayCommanderMustBeCfc { get; set; } = true;

    // ── Segunda ──
    public int MondayPermanences { get; set; } = 1;
    public int MondaySentinels { get; set; } = 3;
    public int MondayCommanders { get; set; } = 1;
    public bool MondayCommanderMustBeCfc { get; set; } = true;

    // ── Terça ──
    public int TuesdayPermanences { get; set; } = 1;
    public int TuesdaySentinels { get; set; } = 3;
    public int TuesdayCommanders { get; set; } = 1;
    public bool TuesdayCommanderMustBeCfc { get; set; } = true;

    // ── Quarta ──
    public int WednesdayPermanences { get; set; } = 1;
    public int WednesdaySentinels { get; set; } = 3;
    public int WednesdayCommanders { get; set; } = 1;
    public bool WednesdayCommanderMustBeCfc { get; set; } = true;

    // ── Quinta ──
    public int ThursdayPermanences { get; set; } = 1;
    public int ThursdaySentinels { get; set; } = 3;
    public int ThursdayCommanders { get; set; } = 1;
    public bool ThursdayCommanderMustBeCfc { get; set; } = true;

    // ── Sexta ──
    public int FridayPermanences { get; set; } = 2;
    public int FridaySentinels { get; set; } = 3;
    public int FridayCommanders { get; set; } = 1;
    public bool FridayCommanderMustBeCfc { get; set; } = true;

    // ── Sábado ──
    public int SaturdayPermanences { get; set; } = 2;
    public int SaturdaySentinels { get; set; } = 3;
    public int SaturdayCommanders { get; set; } = 1;
    public bool SaturdayCommanderMustBeCfc { get; set; } = true;

    // ── Helpers ──

    public int GetPermanences(DayOfWeek day) => day switch
    {
        DayOfWeek.Sunday => SundayPermanences,
        DayOfWeek.Monday => MondayPermanences,
        DayOfWeek.Tuesday => TuesdayPermanences,
        DayOfWeek.Wednesday => WednesdayPermanences,
        DayOfWeek.Thursday => ThursdayPermanences,
        DayOfWeek.Friday => FridayPermanences,
        DayOfWeek.Saturday => SaturdayPermanences,
        _ => MondayPermanences
    };

    public int GetSentinels(DayOfWeek day) => day switch
    {
        DayOfWeek.Sunday => SundaySentinels,
        DayOfWeek.Monday => MondaySentinels,
        DayOfWeek.Tuesday => TuesdaySentinels,
        DayOfWeek.Wednesday => WednesdaySentinels,
        DayOfWeek.Thursday => ThursdaySentinels,
        DayOfWeek.Friday => FridaySentinels,
        DayOfWeek.Saturday => SaturdaySentinels,
        _ => MondaySentinels
    };

    public int GetCommanders(DayOfWeek day) => day switch
    {
        DayOfWeek.Sunday => SundayCommanders,
        DayOfWeek.Monday => MondayCommanders,
        DayOfWeek.Tuesday => TuesdayCommanders,
        DayOfWeek.Wednesday => WednesdayCommanders,
        DayOfWeek.Thursday => ThursdayCommanders,
        DayOfWeek.Friday => FridayCommanders,
        DayOfWeek.Saturday => SaturdayCommanders,
        _ => MondayCommanders
    };

    public bool MustCommanderBeCfc(DayOfWeek day) => day switch
    {
        DayOfWeek.Sunday => SundayCommanderMustBeCfc,
        DayOfWeek.Monday => MondayCommanderMustBeCfc,
        DayOfWeek.Tuesday => TuesdayCommanderMustBeCfc,
        DayOfWeek.Wednesday => WednesdayCommanderMustBeCfc,
        DayOfWeek.Thursday => ThursdayCommanderMustBeCfc,
        DayOfWeek.Friday => FridayCommanderMustBeCfc,
        DayOfWeek.Saturday => SaturdayCommanderMustBeCfc,
        _ => MondayCommanderMustBeCfc
    };

    public void SetPermanences(DayOfWeek day, int value)
    {
        switch (day)
        {
            case DayOfWeek.Sunday: SundayPermanences = value; break;
            case DayOfWeek.Monday: MondayPermanences = value; break;
            case DayOfWeek.Tuesday: TuesdayPermanences = value; break;
            case DayOfWeek.Wednesday: WednesdayPermanences = value; break;
            case DayOfWeek.Thursday: ThursdayPermanences = value; break;
            case DayOfWeek.Friday: FridayPermanences = value; break;
            case DayOfWeek.Saturday: SaturdayPermanences = value; break;
        }
    }

    public void SetSentinels(DayOfWeek day, int value)
    {
        switch (day)
        {
            case DayOfWeek.Sunday: SundaySentinels = value; break;
            case DayOfWeek.Monday: MondaySentinels = value; break;
            case DayOfWeek.Tuesday: TuesdaySentinels = value; break;
            case DayOfWeek.Wednesday: WednesdaySentinels = value; break;
            case DayOfWeek.Thursday: ThursdaySentinels = value; break;
            case DayOfWeek.Friday: FridaySentinels = value; break;
            case DayOfWeek.Saturday: SaturdaySentinels = value; break;
        }
    }

    public void SetCommanders(DayOfWeek day, int value)
    {
        switch (day)
        {
            case DayOfWeek.Sunday: SundayCommanders = value; break;
            case DayOfWeek.Monday: MondayCommanders = value; break;
            case DayOfWeek.Tuesday: TuesdayCommanders = value; break;
            case DayOfWeek.Wednesday: WednesdayCommanders = value; break;
            case DayOfWeek.Thursday: ThursdayCommanders = value; break;
            case DayOfWeek.Friday: FridayCommanders = value; break;
            case DayOfWeek.Saturday: SaturdayCommanders = value; break;
        }
    }

    public void SetCommanderMustBeCfc(DayOfWeek day, bool value)
    {
        switch (day)
        {
            case DayOfWeek.Sunday: SundayCommanderMustBeCfc = value; break;
            case DayOfWeek.Monday: MondayCommanderMustBeCfc = value; break;
            case DayOfWeek.Tuesday: TuesdayCommanderMustBeCfc = value; break;
            case DayOfWeek.Wednesday: WednesdayCommanderMustBeCfc = value; break;
            case DayOfWeek.Thursday: ThursdayCommanderMustBeCfc = value; break;
            case DayOfWeek.Friday: FridayCommanderMustBeCfc = value; break;
            case DayOfWeek.Saturday: SaturdayCommanderMustBeCfc = value; break;
        }
    }

    public int GetTotalForDay(DayOfWeek day) => GetPermanences(day) + GetSentinels(day) + GetCommanders(day);
}
