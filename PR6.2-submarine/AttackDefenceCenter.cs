using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2_submarine
{
    internal class AttackDefenceCenter
    {
        static void Shake(SubmarineHub form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        public void FireEvent()
        {
            Random random = new Random();
            int randomEvent = random.Next(0, 2);
            switch (randomEvent)
            {
                case 0: MessageBox.Show("Промах, капитан. Вот досада!", "Помощник капитана", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case 1: MessageBox.Show("Выстрел попал точно в цель, капитан! Так держать!", "Помощник капитана", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
            }
        }

        public void Innit(SubmarineHub form)
        {
            Shake(form);
            FireEvent();
        }
    }
}
