namespace esercizio11
{
    internal class Program
    {
        static int countelements(int[] vet,int x)
        {
            int count = 0;
            for (int i = 0; i < vet.Length; i++) 
            {
                if (vet[i] == x) 
                { 
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] vet1= { 1, 2, 3, 4, 5, 6, 7, 8, 5, 6, 54, 3, 3, 2, 2, };
            Console.WriteLine(" dimmi la x che vuoi che ti controlli quante volte sta dentro il vettore ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" la x ci sta "+ countelements(vet1,n));
        }
    }
}
