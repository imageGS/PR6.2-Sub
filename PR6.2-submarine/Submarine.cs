using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2_submarine
{
    internal class Submarine
    {
        public ControlCenter cc /*{ get; private set; }*/ = new ControlCenter();
        public AttackDefenceCenter adc { get; private set; } = new AttackDefenceCenter();
        public IntelligenceCenter ic { get; private set; } = new IntelligenceCenter();
        
        public void Move()
        {

        }

        public void Fire(SubmarineHub form) 
        {
            adc.Innit(form);
        }
        public bool TurnOnRadar()
        {
            if (ic.IsOn == false)
            {
                ic.IsOn = true;
                return true;
            }
            else
            {
                ic.IsOn = false;
                return false;
            }
        }
        public void RadarSpot()
        {
            ic.RadarSpotEvent();
        }
    }
}