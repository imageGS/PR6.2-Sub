using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2_submarine
{
    internal class CaptainsRoom
    {
        void ShelfEvent()
        {
            Random random = new Random();
            int randomEvent = random.Next(0, 5);
            switch (randomEvent)
            {
                case 0: MessageBox.Show("Внутри одного из ящиков вы находите свою старую курительную трубку. Вас переполняют тёплые чувства, связанные с предыдущими плаваниями. Вы кладёте её обратно.", "Тумба", MessageBoxButtons.OK); break;
                case 1: MessageBox.Show("Открыв один из ящиков, вы замечаете армейский жетон, пренадлежавший вашему отцу. От отдал его вам, как он сам выразился, на удачу. Вы кладёте его обратно.", "Тумба", MessageBoxButtons.OK); break;
                case 2: MessageBox.Show("Открытый вами ящик оказался пуст. Вас слегка тревожит странное чувство обиды. Ваше любопытство неудовлетворено.", "Тумба", MessageBoxButtons.OK); break;
                case 3: MessageBox.Show("Ручка. В одном из ящиков вы находите именную ручку. Вы получили её ещё будучи студентом, победив в конкурсе. Хорошие времена. Вы кладёте её обратно.", "Тумба", MessageBoxButtons.OK); break;
            }
        }
        public void Init()
        {
            ShelfEvent();
        }
    }
}
