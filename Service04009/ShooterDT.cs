using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service04009
{
    // classe criada para facilitar o uso do .DataSource do DataGridView
    internal class ShooterDT
    {
        public int Número { get; private set; }
        public string Nome_De_Guerra { get; private set; }
        public bool Cfc { get; private set; } = false; 
        public int Número_De_Serviços_Tirados { get; private set; } = 0;
        public bool Domingo_Manhã { get; private set; } = true;
        public bool Domingo_Noite { get; private set; } = true;
        public bool Segunda_Manhã { get; private set; } = true;
        public bool Segunda_Noite { get; private set; } = true;
        public bool Terça_Manhã { get; private set; } = true;
        public bool Terça_Noite { get; private set; } = true;
        public bool Quarta_Manhã { get; private set; } = true;
        public bool Quarta_Noite { get; private set; } = true;
        public bool Quinta_Manhã { get; private set; } = true;
        public bool Quinta_Noite { get; private set; } = true;
        public bool Sexta_Manhã { get; private set; } = true;
        public bool Sexta_Noite { get; private set; } = true;
        public bool Sábado_Manhã { get; private set; } = true;
        public bool Sábado_Noite { get; private set; } = true;

        public ShooterDT(Shooter shooter) {
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
