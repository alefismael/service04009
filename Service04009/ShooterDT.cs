using System.ComponentModel;

namespace Service04009
{
    // classe criada para facilitar o uso do .DataSource do DataGridView
    internal class ShooterDT
    {
        [DisplayName("Número")]
        public int Número { get; private set; }

        [DisplayName("Nome De Guerra")]
        public string Nome_De_Guerra { get; private set; }

        [DisplayName("CFC")]
        public bool Cfc { get; private set; } = false;

        [DisplayName("Nº Serviços Tirados")]
        public int Número_De_Serviços_Tirados { get; private set; } = 0;

        [DisplayName("Dom Manhã")]
        public bool Domingo_Manhã { get; private set; } = true;

        [DisplayName("Dom Noite")]
        public bool Domingo_Noite { get; private set; } = true;

        [DisplayName("Seg Manhã")]
        public bool Segunda_Manhã { get; private set; } = true;

        [DisplayName("Seg Noite")]
        public bool Segunda_Noite { get; private set; } = true;

        [DisplayName("Ter Manhã")]
        public bool Terça_Manhã { get; private set; } = true;

        [DisplayName("Ter Noite")]
        public bool Terça_Noite { get; private set; } = true;

        [DisplayName("Qua Manhã")]
        public bool Quarta_Manhã { get; private set; } = true;

        [DisplayName("Qua Noite")]
        public bool Quarta_Noite { get; private set; } = true;

        [DisplayName("Qui Manhã")]
        public bool Quinta_Manhã { get; private set; } = true;

        [DisplayName("Qui Noite")]
        public bool Quinta_Noite { get; private set; } = true;

        [DisplayName("Sex Manhã")]
        public bool Sexta_Manhã { get; private set; } = true;

        [DisplayName("Sex Noite")]
        public bool Sexta_Noite { get; private set; } = true;

        [DisplayName("Sáb Manhã")]
        public bool Sábado_Manhã { get; private set; } = true;

        [DisplayName("Sáb Noite")]
        public bool Sábado_Noite { get; private set; } = true;

        public ShooterDT(Shooter shooter)
        {
            Número = shooter.numAtr;
            Nome_De_Guerra = shooter.warName;
            Cfc = shooter.isCfc;
            Número_De_Serviços_Tirados = shooter.CountService();
            Domingo_Manhã = shooter.sunMorning;
            Domingo_Noite = shooter.sunNight;
            Segunda_Manhã = shooter.monMorning;
            Segunda_Noite = shooter.monNight;
            Terça_Manhã = shooter.tueMorning;
            Terça_Noite = shooter.tueNight;
            Quarta_Manhã = shooter.wedMorning;
            Quarta_Noite = shooter.wedNight;
            Quinta_Manhã = shooter.thuMorning;
            Quinta_Noite = shooter.thuNight;
            Sexta_Manhã = shooter.friMorning;
            Sexta_Noite = shooter.friNight;
            Sábado_Manhã = shooter.satMorning;
            Sábado_Noite = shooter.satNight;
        }
    }
}
