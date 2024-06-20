using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPInterfaceBallers
{
    internal class Defenders : IBallers
    {
        public string NameSurname { get; set; }
        public int JerseyNumber { get; set; }
        private byte _shootingPower;
        public byte ShootingPower
        {
            get { return _shootingPower; }
            set
            {
                if (value > 70)
                {
                    _shootingPower = 70;
                    Console.WriteLine("Shooting power of a defender can't be higher than 70");
                }
                else
                    _shootingPower = value;
            }
        }
        public byte Reflexes { get; set; }
        public bool NationalTeamParticipater { get; set; }
        public byte Stamina { get; set; }
        public bool LeftFooted { get; set; }
        public string GetInjured()
        {
            return "Got injured..";
        }
        public string SaveBall()
        {
            return "Pressed the adversary..";
        }
        public string Shoot()
        {
            return "Shoot from afar..."; ;
        }
    }
}
