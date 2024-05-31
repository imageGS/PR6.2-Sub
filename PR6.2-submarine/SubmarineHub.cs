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
    public partial class SubmarineHub : Form
    {
        Submarine submarine = new Submarine();
        public SubmarineHub()
        {
            InitializeComponent();
        }

        private void triggerRadar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Радар", this.triggerRadar, 15, -25);
        }

        private void triggerAttack_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Запуск торпеды в противника", this.triggerAttack, -55, -25);
        }

        private void triggerRadar_Click(object sender, EventArgs e)
        {
            Hide();
            Radar radar = new Radar();
            radar.Show();
        }

        private void triggerExit_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Выход", this.triggerExit, 40, 50);
        }

        private void triggerExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void triggerAttack_Click(object sender, EventArgs e)
        {
            submarine.Fire(this);
        }

        private void triggerToRoom_Click(object sender, EventArgs e)
        {
            Hide();
            Room room = new Room();
            room.Show();
        }

        private void triggerToRoom_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("В комнату капитана", this.triggerToRoom, -30, -30);
        }
    }
}
