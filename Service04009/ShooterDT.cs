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

        public ShooterDT(Shooter shooter) {
            Número = shooter.numAtr;
            Nome_De_Guerra = shooter.warName;
            Cfc = shooter.isCfc;
            Número_De_Serviços_Tirados = shooter.CountService();
        }
    }
}
