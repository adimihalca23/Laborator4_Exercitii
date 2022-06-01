using System;

namespace Laborator4_Exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex5(5);
        }

        //Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura.Scrieti o functie care va inversa elementele
        //vectorului, apelati o si afisati I rezultatul
        static void Ex1()
        {
            Console.WriteLine("Introduceti numarul de elemente ale vectorului: ");

            int nrElemArray = Citeste();
            int[] array = new int[nrElemArray];

            Console.WriteLine($"Introduceti cele {nrElemArray} elemente ale vectorului: ");

            for(int i = 0; i < nrElemArray; i++)
            {
                array[i] = Citeste();
            }

            Console.WriteLine("Inainte de inversare: ");
            AfiseazaArray(array);

            Reverse(array);

            Console.WriteLine("Dupa inversare: ");
            AfiseazaArray(array);
        }

        static void Reverse(int[] arr)
        {
            int pahar, n = arr.Length;

            for(int i = 0; i < arr.Length/2; i++)
            {
                pahar = arr[i];
                arr[i] = arr[n-1];
                arr[n - 1] = pahar;
                n--;
            }
        }

        static void AfiseazaArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
        }

        //Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
        //k.L ungimile celor trei dimensiuni ale matricii , n, m si k, vor fi citite de la tastaura.  Scrieti o functie care va calcula suma
        //elementelor unei astfel de matrici, apelati o si afisati i rezultatul .  Scrieti o functie care va determina elementul cu valoare
        //maxima, apelati o si afisati i rezultatul.
        static void Ex2()
        {

            int n = Citeste();
            int m = Citeste();
            int k = Citeste();

            int[,,] array = new int[n, m, k];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    for(int l = 0; l < k; l++)
                    {
                        array[i, j, l] = Citeste();
                    }
                }
            }
            Afiseaza3DArray(array);

            SumaMatrice(array);
            Console.WriteLine(SumaMatrice(array));

            MaximMatrice(array);
            Console.WriteLine(MaximMatrice(array));
        }

        static int SumaMatrice(int[,,] arr)
        {
            int suma = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int l = 0; l < arr.GetLength(2); l++)
                    {
                        suma += arr[i, j, l];
                    }
                }
            }
            return suma;
        }

        static int MaximMatrice(int[,,] arr)
        {
            int max = arr[0,0,1];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int l = 0; l < arr.GetLength(2); l++)
                    {
                        if(arr[i, j, l] > max)
                        {
                            max = arr[i, j, l];
                        }
                    }
                }
            }
            return max;
        }

        static void Afiseaza3DArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int l = 0; l < arr.GetLength(2); l++)
                    {
                        Console.Write($"{arr[i,j,l]}, ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        //Cititide la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile n m,respectiv n, m L ungimile celor doua
        //dimensiuni ale matricii , m si n , vor fi citite de latastaura.Scrieti o functie care va calcula produsul celor doua matrici ,
        //apelati o si afisati-i rezultatul
        static void Ex3()
        {
            int[,] array1 = CitesteMatrice();
            int[,] array2 = CitesteMatrice();
            int[,] array3 = new int[array1.GetLength(0), array1.GetLength(1)];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1);)
                {
                    array3[i, j] = 0;
                    for (int k = 0; k < array1.GetLength(1); k++)
                    {
                        array3[i, j] += array1[i, k] * array2[k, j];
                    }
                }
            }
            AfiseazaMatrice2D(array3);
        }

        static int[,] CitesteMatrice()
        {
            int n = Citeste();
            int m = Citeste();
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Citeste();
                }
            }
            return array;
        }

        static void AfiseazaMatrice2D(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }



        //Scrieti o functie recursiva care va afisa in ordine elementele unui vector deintregi
        static void Ex4(int[] arr, int n)
        {
            if (n >= arr.Length)
            {
                return;
            }

            Console.WriteLine(arr[n]);

            Ex4(arr, n + 1);
        }


        //Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati-o si afisati-i rezultatul.
        static int Ex5(int n)
        {
            int suma = 0;

            if (n <= 0)
            {
                return suma;
            }

            suma = n + Ex5(n - 1);

            Console.WriteLine(suma);
            return suma;
        }


        //Scrieti o functie recursiva care va calcula al n-lea element din sirul lui Fibonacci, n fiind citit de la tastatura
        static void Ex6()
        {
            int numar = Citeste();

            if (numar == 1)
            {
                Console.WriteLine("Primul numar este: " + 0);
            }
            else if (numar <= 0)
            {
                Console.WriteLine("Introduceti un numar mai mare decat 0!");
            }
            else
            {
                Console.WriteLine("Al n-lea numar este ultimul numar.");
                Fibonacci(numar, 0, 1);
            }
        }

        static void Fibonacci(int n, int a, int b)
        {
            if (n <= 1)
            {
                return;
            }

            int c = a + b;
            a = b;
            b = c;

            Console.WriteLine(c);

            Fibonacci(n - 1, a, b);
        }


        //Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va afisa urmatoarea piramida a numerelor:
        static void Ex7(int n)
        {
            if (n <= 0)
            {
                return;
            }

            string rand = " ";

            for (int i = 0; i < n; i++)
            {
                rand += n.ToString();
            }

            Ex7(n - 1);

            Console.WriteLine(rand);
        }



        static int Citeste()
        {
            Console.WriteLine("Numar: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
    }
}
