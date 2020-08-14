using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollSlot
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            bool play;
            do
            {
                Console.WriteLine("Вращайте автомат");
                machine.Spin();
                for (int i = 0; i < machine.slots.Length; i++)
                {
                    Console.Write($"{machine.slots[i].number}");
                }
                if ((machine.slots[0].number == machine.slots[1].number) && (machine.slots[1].number == machine.slots[2].number))
                {
                    Console.WriteLine("\nВы выиграли");
                }
                else
                {
                    Console.WriteLine("\nВы проиграли");
                }
                Console.WriteLine("Вращать еще раз? y/n");
                play = machine.SpinAgain(Console.ReadLine());
            }
            while(play);
        }
    }
}
