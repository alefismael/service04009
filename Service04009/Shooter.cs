using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service04009
{
    internal class Shooter : IComparable<Shooter>
    {
        public int numAtr { get; private set; } // Número do atirador
        public string warName { get; private set; } // Nome de guerra do atirador
        public bool isCfc { get; private set; } = false; // Booleano se o atirador faz CFC (true or false)
        public int numOfService { get; private set; } = 0; // Número de serviços que o atirador já foi escalado
        public int numServiceExtra { get; private set; } = 0; // Serviços extras tirados
        // numServiceExtra pode variar, se o cara fez coisa errada e pegou o serviço do outro +1
        // se pegou o serviço mas por outro pessoa ter feito coisa errada pegar o serviço dele aí -1

        // Disponibilidade do atirador para serviços
        private bool sunMorning { get; set; } = true;
        private bool sunNight { get; set; } = true;
        private bool monMorning { get; set; } = true;
        private bool monNight { get; set; } = true;
        private bool tueMorning { get; set; } = true;
        private bool tueNight { get; set; } = true;
        private bool wedMorning { get; set; } = true;
        private bool wedNight { get; set; } = true;
        private bool thuMorning { get; set; } = true;
        private bool thuNight { get; set; } = true;
        private bool friMorning { get; set; } = true;
        private bool friNight { get; set; } = true;
        private bool satMorning { get; set; } = true;
        private bool satNight { get; set; } = true;

        // Construtor com parâmetros básicos
        public Shooter(int numAtr, string warName, bool isCfc)
        {
            this.numAtr = numAtr;
            this.warName = warName;
            this.isCfc = isCfc;
        }

        // Construtor com todos os parâmetros básicos necessários (já que por padrão o atirador pode todo dia)
        public Shooter(int numAtr, string warName, bool isCfc, int numOfService, int numServiceExtra)
        {
            this.numAtr = numAtr;
            this.warName = warName;
            this.isCfc = isCfc;
            this.numOfService = numOfService;
            this.numServiceExtra = numServiceExtra;
        }

        // Construtor com parâmetros de disponibilidade
        public Shooter(int numAtr, string warName, bool isCfc, int numOfService, int numServiceExtra, bool sunMorning, bool sunNight, bool monMorning, bool monNight,
                        bool tueMorning, bool tueNight, bool wedMorning, bool wedNight,
                        bool thuMorning, bool thuNight, bool friMorning, bool friNight,
                        bool satMorning, bool satNight)
        {
            this.numAtr = numAtr;
            this.warName = warName;
            this.isCfc = isCfc;
            this.numOfService = numOfService;
            this.numServiceExtra = numServiceExtra;
            this.sunMorning = sunMorning;
            this.sunNight = sunNight;
            this.monMorning = monMorning;
            this.monNight = monNight;
            this.tueMorning = tueMorning;
            this.tueNight = tueNight;
            this.wedMorning = wedMorning;
            this.wedNight = wedNight;
            this.thuMorning = thuMorning;
            this.thuNight = thuNight;
            this.friMorning = friMorning;
            this.friNight = friNight;
            this.satMorning = satMorning;
            this.satNight = satNight;
        }



        // Método para mudar o número de guerra do atirador (apenas número positivo)
        public bool ChangeNumAtr(int numAtr)
        {
            if (numAtr > 0)
            {
                this.numAtr = numAtr;
                return true;
            }
            return false;
        }

        // Método para mudar o nome de guerra do atirador (só pode ter letras, sem => %$@#!, etc)
        public bool ChangeWarName(string warName)
        {
            // Expressão regular que verifica se a string contém apenas letras (incluindo acentuadas) e espaços
            Regex regex = new Regex(@"^[\p{L}\s]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);

            // Retorna true se a string corresponder à expressão regular, false caso contrário
            if (regex.IsMatch(warName))
            {
                this.warName = warName;
                return true;
            }
            return false;
        }

        // Método para definir se o atirador é do cfc ou não retornando verdadeiro se a mudança foi realizada
        public bool ChangeIsCfc(bool isCfc)
        {
            this.isCfc = isCfc;
            return true;
        }

        // Método para somar a quantidade de escala de serviço que o atirador pegou em +1
        public bool AddNumService()
        {
            numOfService++;
            return true;
        }

        // Método para mudar a quantidade de escala de serviço que o atirador pegou (apenas positivo)
        public bool ChanceNumService(int numOfService)
        {
            if (numOfService > 0)
            {
                this.numOfService = numOfService;
                return true;
            }
            return false;
        }

        // Método para mudar o numServiceExtra de um atirador que perdeu serviço porque outro fez algo errado
        public bool SubtractServiceExtra()
        {
            numServiceExtra--;
            return true;
        }

        // Método para mudar o numServiceExtra de um atirador que fez algo errado e ganhou um serviço
        public bool AddServiceExtra()
        {
            numServiceExtra++;
            return true;
        }

        // Método que informa a quantidade de serviços que o atirador realmente tirou
        public int CountService()
        {
            return numOfService + numServiceExtra;
        }

        // Método para definir a disponibilidade do atirador para um dia específico
        public void SetAvailabilityByDayOfWeek(DayOfWeek dayOfWeek, bool available)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    sunMorning = available;
                    sunNight = available;
                    break;
                case DayOfWeek.Monday:
                    monMorning = available;
                    monNight = available;
                    break;
                case DayOfWeek.Tuesday:
                    tueMorning = available;
                    tueNight = available;
                    break;
                case DayOfWeek.Wednesday:
                    wedMorning = available;
                    wedNight = available;
                    break;
                case DayOfWeek.Thursday:
                    thuMorning = available;
                    thuNight = available;
                    break;
                case DayOfWeek.Friday:
                    friMorning = available;
                    friNight = available;
                    break;
                case DayOfWeek.Saturday:
                    satMorning = available;
                    satNight = available;
                    break;
            }
        }

        // Método para verificar se o atirador pode pegar o serviço em um dia com base na data e dia(0) ou noite(1)
        public bool IsOk(DateOnly date, int period)
        {
            if (isCfc)
            {
                // Se for CFC, verifica apenas o período noturno
                if (period == 1)
                {
                    return date.DayOfWeek switch
                    {
                        DayOfWeek.Sunday => sunNight,
                        DayOfWeek.Monday => monNight,
                        DayOfWeek.Tuesday => tueNight,
                        DayOfWeek.Wednesday => wedNight,
                        DayOfWeek.Thursday => thuNight,
                        DayOfWeek.Friday => friNight,
                        DayOfWeek.Saturday => satNight,
                        _ => false,
                    };
                }
                return false;
            }
            else
            {
                // Se não for CFC, verifica o período da manhã e noite
                if (period == 0)
                {
                    return date.DayOfWeek switch
                    {
                        DayOfWeek.Sunday => sunMorning,
                        DayOfWeek.Monday => monMorning,
                        DayOfWeek.Tuesday => tueMorning,
                        DayOfWeek.Wednesday => wedMorning,
                        DayOfWeek.Thursday => thuMorning,
                        DayOfWeek.Friday => friMorning,
                        DayOfWeek.Saturday => satMorning,
                        _ => false,
                    };
                }
                else if (period == 1)
                {
                    return date.DayOfWeek switch
                    {
                        DayOfWeek.Sunday => sunNight,
                        DayOfWeek.Monday => monNight,
                        DayOfWeek.Tuesday => tueNight,
                        DayOfWeek.Wednesday => wedNight,
                        DayOfWeek.Thursday => thuNight,
                        DayOfWeek.Friday => friNight,
                        DayOfWeek.Saturday => satNight,
                        _ => false,
                    };
                }

                return false;
            }
        }

        public int CompareTo(Shooter? other)
        {
            if (other == null) return 1;

            // Calcula o total de serviços, incluindo o bônus
            int myTotalService = numOfService - numServiceExtra;
            int otherTotalService = other.numOfService - other.numServiceExtra;

            // Compara os totais de serviço
            if (myTotalService < otherTotalService) return -1;
            if (myTotalService > otherTotalService) return 1;
            return 0;
        }

        public override string ToString()
        {
            return $"Atirador {numAtr} {warName}, {(isCfc ? "faz CFC" : "não faz CFC")} e tirou {CountService()} serviços.";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Shooter other = (Shooter)obj;

            // Verifica todas as propriedades públicas e privadas
            return numAtr == other.numAtr &&
                   warName == other.warName &&
                   isCfc == other.isCfc &&
                   numOfService == other.numOfService &&
                   numServiceExtra == other.numServiceExtra &&
                   sunMorning == other.sunMorning &&
                   sunNight == other.sunNight &&
                   monMorning == other.monMorning &&
                   monNight == other.monNight &&
                   tueMorning == other.tueMorning &&
                   tueNight == other.tueNight &&
                   wedMorning == other.wedMorning &&
                   wedNight == other.wedNight &&
                   thuMorning == other.thuMorning &&
                   thuNight == other.thuNight &&
                   friMorning == other.friMorning &&
                   friNight == other.friNight &&
                   satMorning == other.satMorning &&
                   satNight == other.satNight;
        }
        public override int GetHashCode()
        {
            unchecked // Overflow é permitido para o código hash
            {
                int hash = 17; // Número primo inicial para evitar multiplicação por zero

                // Combina o hash com base em todas as propriedades relevantes da classe
                hash = hash * 23 + numAtr.GetHashCode();
                hash = hash * 23 + (warName != null ? warName.GetHashCode() : 0);
                hash = hash * 23 + isCfc.GetHashCode();
                hash = hash * 23 + numOfService.GetHashCode();
                hash = hash * 23 + numServiceExtra.GetHashCode();
                hash = hash * 23 + sunMorning.GetHashCode();
                hash = hash * 23 + sunNight.GetHashCode();
                hash = hash * 23 + monMorning.GetHashCode();
                hash = hash * 23 + monNight.GetHashCode();
                hash = hash * 23 + tueMorning.GetHashCode();
                hash = hash * 23 + tueNight.GetHashCode();
                hash = hash * 23 + wedMorning.GetHashCode();
                hash = hash * 23 + wedNight.GetHashCode();
                hash = hash * 23 + thuMorning.GetHashCode();
                hash = hash * 23 + thuNight.GetHashCode();
                hash = hash * 23 + friMorning.GetHashCode();
                hash = hash * 23 + friNight.GetHashCode();
                hash = hash * 23 + satMorning.GetHashCode();
                hash = hash * 23 + satNight.GetHashCode();

                return hash;
            }
        }
    }
}
