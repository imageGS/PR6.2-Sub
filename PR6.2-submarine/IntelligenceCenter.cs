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
        public delegate void StringEvent(string message);
        public static event StringEvent OnStringRecieved;
        public DialogResult Result { get; private set; }
        public bool IsOn { get; set; } = false;

        public void RadarSpotEvent()
        {
            string message = "";
            Random random = new Random();
            int randomEvent = random.Next(0, 8);
            switch (randomEvent)
            {
                case 0:
                    message = "На радаре вы не замечаете ничего примечательного.";
                    break;
                case 1:
                    message = "Ваше внимание привлекает небольшая недвижимая точка на юго-востоке.";
                    break;
                case 2:
                    message = "Ваше внимание привлекает небольшая точка, двигающаяся параллельно вашей субмарине.";
                    break;
                case 3:
                    message = "Ваше внимание привлекает статичный объект средних размеров позади.";
                    break;
                case 4:
                    message = "Радар показывает, что позади вашей субмарины проплывает нечто больших размеров. Жуть.";
                    break;
                case 5:
                    message = "На радаре показался косяк рыб. Интересно...";
                    break;
                case 6:
                    message = "Несмотря на глубину, на радаре показались несколько довольно крупных точек, движущихся впереди субмарины.";
                    break;
                case 7:
                    message = "Ваше внимание привлекает несколько крохотных точек на западе. Что же это? Рыбы?";
                    break;
            }
            OnStringRecieved?.Invoke(message);
        }
    }
}
