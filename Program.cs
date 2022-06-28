namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void StampaArray(int[] array)
            {
                Console.Write("[");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }


                Console.WriteLine("]");

            }
            int Quadrato(int num)
            {
                return num * num;
            }


            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] arrayQuadrato = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    arrayQuadrato[i] = Quadrato(array[i]);
                }

                return arrayQuadrato;
            }


            int sommaElementiArray(int[] array)
            {
                int somma = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    somma += array[i];
                }

                return somma;
            }
        }
    }
}