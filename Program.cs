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
        // esercizio 12
        static bool contains (int[] vet, int x)
        {
            
         
            for (int i = 0; i<vet.Length; i++) 
            { 
                if (vet[i] == x)
                {
                    return true;
                }
               
            }
            return false;
        }
        // esercizio 13

        static int findelement(int[] vet, int x)
        {

            int posizione = -2;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == x)
                {
                    posizione=i;
                }
              

            }
            if(posizione== -2) 
            {
                posizione = -1;
            }
            return posizione;
        }

        static void Main(string[] args)
        {
            int[] vet1= { 1, 2, 3, 4, 5, 6, 7, 8, 5, 6, 54, 3, 3, 2, 2, };
            Console.WriteLine(" dimmi la x che vuoi che ti controlli quante volte sta dentro il vettore ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" la x si trova nel vettore in tutto queste volte "+ countelements(vet1,n));
            Console.WriteLine(" la x si trova nel vettore  " + contains(vet1, n));
            Console.WriteLine(" il vettore si trova in posizione"+ findelement(vet1,n) + " se esce -1 non cè nel vettore la tua x ");
      
        }
    }
}
