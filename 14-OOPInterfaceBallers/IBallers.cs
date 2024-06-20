using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPInterfaceBallers
{
    internal interface IBallers
    {
        public string NameSurname { get; set; }
        public int JerseyNumber { get; set; }
        public byte ShootingPower { get; set; }
        public byte Reflexes { get; set; }
        public bool NationalTeamParticipater { get; set; }
        public byte Stamina { get; set; }
        public bool LeftFooted { get; set; }
        public string Shoot(); //body shall be defined at implementation, because interface.
        public string SaveBall();
        public string GetInjured();
    }
}
