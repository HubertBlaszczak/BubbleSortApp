using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    internal class BubbleMethod
    {
        public static void bubbleMethod(List<int> unsortedList)
        {
            
            int counter = 1;
            if (unsortedList.Count != 0)
            {
                Console.WriteLine("Przed sortowaniem: ");
                foreach (int i in unsortedList)
                {
                    Console.Write(" " + i + ",");
                }
                Console.WriteLine();

                while (counter != unsortedList.Count)
                {
                    counter = 1;
                    for (int i = 1; i < unsortedList.Count; i++)
                    {
                        if (unsortedList[i - 1] > unsortedList[i])
                        {
                            int changer = unsortedList[i];
                            unsortedList[i] = unsortedList[i - 1];
                            unsortedList[i - 1] = changer;
                        }
                        else
                        {
                            counter++;
                        }

                    }
                }
                Console.WriteLine("Sortowanie zakończone, wynik sortowania: ");
                foreach (int i in unsortedList)
                {
                    Console.Write(" " + i + ",");
                }
            }
            Console.WriteLine();
        }
    }
}
