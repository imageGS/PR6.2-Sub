using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2_submarine
{
    internal class EventManage
    {
        void RadarEvent(string message)
        {
            MessageBox.Show(message,"Мысли");
        }
        public void Init()
        {
            IntelligenceCenter.OnStringRecieved+=RadarEvent;
        }
    }
}
