namespace Collection
{
    internal class Program
    {
        //1.
        //static void Main(string[] args)
        //{
        //    int N = 4;
        //    List<(int, int)> chapters = new List<(int, int)> {
        //    (1, 4),
        //    (5, 7),
        //    (9, 16),
        //    (17, 26)
        //};
        //    int K = 7; 

        //    int remainingChapters = FindRemainingChapters(N, chapters, K);
        //    Console.WriteLine(remainingChapters);
        //}

        //static int FindRemainingChapters(int N, List<(int, int)> chapters, int K)
        //{
        //    int remainingChapters = 0;

        //    foreach ((int startPage, int endPage) in chapters)
        //    {
        //        if (K >= startPage && K <= endPage)
        //        {                    
        //            remainingChapters = N - chapters.IndexOf((startPage, endPage));
        //            break;
        //        }
        //    }

        //    return remainingChapters;
        //}


        //2.
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            List<int> basketA = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> basketB = Console.ReadLine().Split().Select(int.Parse).ToList();

            
            basketA.Sort();
            basketB.Sort();

            int i = 0;
            int j = N - 1;

            
            while (K > 0 && i < N && j >= 0 && basketA[i] < basketB[j])
            {
                basketA[i] = basketB[j];
                i++;
                j--;
                K--;
            }

            
            int maxSellingPrice = basketA.Sum();

            Console.WriteLine(maxSellingPrice);
        }

    }
}