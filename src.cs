using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class MAIN  {
    public static void Main(string[] args) {
        
        MAIN m = new MAIN();

        string line = Console.ReadLine();
        string[] n_arr_str = line.Split(' ');
        
        int N = n_arr_str.Count();
        
        List<int> A = new List<int>();
        for(int i = 0; i < N; i++){
            A.Add(Convert.ToInt32(n_arr_str[i]));
        }
        Console.WriteLine(m.solve(A));
   }

   public int solve(List<int> A){
            if (A.Count() == 1) return 1;
            int N = A.Count();
            int max = Max(A, N);
            int min = Min(A, N);

            if (max == min) return 1;

            int max_i = -1;
            int min_i = -1;
            int len = N;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == max)
                {
                    max_i = i;
                    if (min_i > -1)
                    {
                        len = Min(len, Abs(max_i - min_i) + 1);
                    }
                }
                else if (A[i] == min)
                {
                    min_i = i;
                    if(max_i > -1)
                    {
                        len = Min(len, Abs(max_i - min_i) + 1);
                    }
                }
            }
            return len;
     }

 

        public int Abs(int value)

        {

            if (value < 0)

            {

                return (value * (-1));

            }

            return value;

        }

 

        public int Min(int a, int b)

        {

            if (a <= b)

                return a;

            else

                return b;

        }

 

        public int Min(List<int> arr, int size)

        {

            int min = arr[0];

            for (int i = 0; i < size; i++)

            {

                if (arr[i] < min)

                {

                    min = arr[i];

                }

            }

            return min;

        }

 

        public int Max(List<int> arr, int size)

        {

            int max = arr[0];

            for (int i = 0; i < size; i++)

            {

                if (arr[i] > max)

                {

                    max = arr[i];

                }

            }

            return max;

        }

 

    }
