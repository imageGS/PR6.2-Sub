using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR6._2_submarine;

namespace PR6._2_submarine
{
    internal class IntelligenceCenter
    {
        public DialogResult Result { get; private set; }
        public bool IsOn { get; set; } = false;

        public void RadarSpotEvent()
        {
            Random random = new Random();
            int randomEvent = random.Next(0, 8);
            switch (randomEvent)
            {
                case 0:
                    MessageBox.Show("На радаре вы не замечаете ничего примечательного.","Мысли");
                    break;
                case 1:
                    MessageBox.Show("Ваше внимание привлекает небольшая недвижимая точка на юго-востоке.", "Мысли");
                    break;
                case 2:
                    MessageBox.Show("Ваше внимание привлекает небольшая точка, двигающаяся параллельно вашей субмарине.", "Мысли");
                    break;
                case 3:
                    MessageBox.Show("Ваше внимание привлекает статичный объект средних размеров позади.", "Мысли");
                    break;
                case 4:
                    MessageBox.Show("Радар показывает, что позади вашей субмарины проплывает нечто больших размеров. Жуть.", "Мысли");
                    break;
                case 5:
                    MessageBox.Show("На радаре показался косяк рыб. Интересно...", "Мысли");
                    break;
                case 6:
                    MessageBox.Show("Несмотря на глубину, на радаре показались несколько довольно крупных точек, движущихся впереди субмарины.", "Мысли");
                    break;
                case 7:
                    MessageBox.Show("Ваше внимание привлекает несколько крохотных точек на западе. Что же это? Рыбы?", "Мысли");
                    break;
            }
        }
    }
}
