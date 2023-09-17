using BubbleSortApp;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> unsortedList1 = new List<int> { };
        List<int> unsortedList2 = new List<int> { 1, 2, 5, 3, 1, 7, 9, 1, 12, 83, 1, 5, 3, 2 };
        List<int> unsortedList3 = new List<int> { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1 };
        List<int> unsortedList4 = new List<int> { 2, 2, 2, 2 };
        List<int> unsortedList5 = new List<int> { 1, 2 };
        List<int> unsortedList6 = new List<int> { 2, 1 };

        BubbleMethod.bubbleMethod(unsortedList1);
        
        BubbleMethod.bubbleMethod(unsortedList2);
        
        BubbleMethod.bubbleMethod(unsortedList3);
        
        BubbleMethod.bubbleMethod(unsortedList4);
        
        BubbleMethod.bubbleMethod(unsortedList5);
        
        BubbleMethod.bubbleMethod(unsortedList6);
        
        
    }
}