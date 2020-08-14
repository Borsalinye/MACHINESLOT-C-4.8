using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollSlot
{
    class Machine
    {
        public Slot[] slots { get; set; }
        public Machine()
        {
            this.slots = new Slot[3];
        }
        public void Spin()
        {
            Random random = new Random();
            for(int i = 0; i < slots.Length; i++)
            {
                slots[i] = new Slot(random.Next(0, 9));
            }
        }
        public bool SpinAgain(string ans)
        {
            bool answer;
            if (ans == "y" || ans == "Y" || ans == "yes" || ans == "YES")
            {
                answer = true;
                return answer;
            }
            else
            {
                answer = false;
                return answer;
            }
        }
    }
}
