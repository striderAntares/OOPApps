using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPInterfaceBallers
{
    internal class Goalkeeper : IGoaliee
    {
        public string NameSurname { get; set; }
        public int JerseyNumber { get; set; }
        public byte ShootingPower { get; set; }
        public byte Reflexes { get; set; }
        public bool NationalTeamParticipater { get; set; }
        public byte Stamina { get; set; }
        public bool LeftFooted { get; set; }
        public bool CanUseHands { get; set; }

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
