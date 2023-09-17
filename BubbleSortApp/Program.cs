internal class Program
{
    private static void Main(string[] args)
    {
        int counter = 1;
        List<int> unsortedList = new List<int>{ 1, 2, 5, 3, 1, 7, 9, 1, 12, 83, 1, 5, 3, 2 };
        if (unsortedList.Count != 0 || unsortedList != null)
        {
            while (counter != unsortedList.Count - 1)
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
            Console.WriteLine("Sortpwanie zakończone, wynik sortowania: ");
            foreach (int i in unsortedList)
            {
                Console.Write(" " + i + ",");
            }
        }
        
        
    }
}