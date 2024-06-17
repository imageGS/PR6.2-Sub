using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2_submarine
{
    public partial class Radar : Form
    {
        Submarine submarine = new Submarine();
        System.Threading.Timer timer;

        public Radar()
        {
            InitializeComponent();
            timer = new System.Threading.Timer(RadarSpot, null, 0, 10000);
            EventManage eventManage = new EventManage();
            eventManage.Init();
        }

        void Radar_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
        }

        void triggerRadarOnOff_Click(object sender, EventArgs e)
        {
            if (submarine.TurnOnRadar() == true)
            {
                pictureBox1.Enabled = true;
                MessageBox.Show("Радар успешно запущен, капитан!", "Помощник капитана", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pictureBox1.Enabled = false;
                MessageBox.Show("Радар успешно выключен, капитан!", "Помощник капитана", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void btnBacktoBridge_Click(object sender, EventArgs e)
        {
            Close();
            SubmarineHub submarine = new SubmarineHub();
            submarine.Show();
        }
        void RadarSpot(object obj)
        {
            if (submarine.ic.IsOn)
            {
                submarine.ic.RadarSpotEvent();
            }
        }
        private void Radar_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
            timer = null;
        }
    }
}