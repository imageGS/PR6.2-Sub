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
            int randomEvent = random.Next(0, 7);
            switch (randomEvent)
            {
                case 0: Result = MessageBox.Show("На радаре вы не замечаете ничего необычного. Пусто", "Событие", MessageBoxButtons.OK); break;
                case 1: Result = MessageBox.Show("Ваше внимание привлекает небольшая точка на юго-западе. Интересно, что там.", "Событие", MessageBoxButtons.OK); break;
                case 2: Result = MessageBox.Show("Небольшая тряска застигает вашу субмарину. Молниеносно вернув себе равновесие, вы замечаете большой объект плывущий параллельно субмарине и медленно её обгоняющий. Жуть.", "Событие", MessageBoxButtons.OK); break;
                case 3: Result = MessageBox.Show("На радаре вы не замечаете ничего необычного. Пусто", "Событие", MessageBoxButtons.OK); break;
                case 4: Result = MessageBox.Show("Ваше внимание привлекает скопление небольших точек, движущихся позади субмарины. Косяк рыб, не более.", "Событие", MessageBoxButtons.OK); break;
                case 5: Result = MessageBox.Show("Ваше внимание привлекает скопление объектов среднего размера движущихся на 12 часов от субмарины.", "Событие", MessageBoxButtons.OK); break;
            }
        }
    }
}
