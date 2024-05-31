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
    public partial class Room : Form
    {
        int openCount = 0;
        CaptainsRoom room = new CaptainsRoom();
        public Room()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Осмотреть ящик", this.triggerShelf, 35, -25);
        }

        private void triggerPillow_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Лечь спать", this.triggerPillow, 35, -25);
        }

        private void btnBacktoBridge_Click(object sender, EventArgs e)
        {
            Close();
            SubmarineHub submarineHub = new SubmarineHub();
            submarineHub.Show();
        }

        private void triggerShelf_Click(object sender, EventArgs e)
        {
            if (openCount <= 4)
            {
                openCount++;
                room.Init();
            }
            else
            {
                MessageBox.Show("Вам надоело бесконечно открывать эти ящики. 'Стоит прекратить' - вслух размышляете вы.", "Мысли");
                triggerShelf.BorderStyle = BorderStyle.None;
                triggerShelf.Enabled = false;
            }
        }

        private void triggerPillow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Точно ли я хочу лечь сейчас спать?", "Мысли", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Вы ложитесь на твёрдую армейскую койку. Ваша голова с разгона плюхается на любимую подушку, с которой вы уже столько времени вместе. Ещё некоторое время вы глазами сверлите потолок, обдумывая своё путешествие. Со временем ваши глаза медленно начинают закрываться. Усталость и сонливость берёт верх. Вы засыпаете.", "Мысли", MessageBoxButtons.OK);
                Application.Exit();
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("А, к чёрту, ещё есть работа, которую нужно сделать. Отдохну позже.", "Мысли", MessageBoxButtons.OK);
            }
        }
    }
}
