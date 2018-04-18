using System;

namespace L04_Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(toHexal(Convert.ToInt32(args[0])));
            Console.WriteLine(toDecimal(Convert.ToInt32(args[0])));
        }
        public static int toHexal(int value)
        {
            //if Anweisung schreiben!
            // var multiplicatorSix = (value/6);
            // var addSix = value%6;
            // var x = 10*multiplicatorSix+addSix;
            // return x;
            // int rest;
            // while(value>0)
            // {
            //     value = value/6;
            //     rest = value%6;
            // }
            int newValue = value/6;
            int[] arr = new int[4];
           
                
                
                for(int i=0;i<=value.ToString().Length+2;i++)
                {
                    newValue = value/6;
                    int rest = value%6;
                    
                    arr[i] = rest;
                    // Console.WriteLine("For-Ergebnis: " + arr[i]);
                    // Console.WriteLine(newValue + " mod " + rest);
                    // Console.WriteLine(newValue);
                    // Console.WriteLine(rest);
                    value = newValue;
                }
                Array.Reverse(arr);
                int newArray = Convert.ToInt32(string.Join("",arr));
               
            return newArray;
        }
        public static int toDecimal(int value)
        {
            int a = Math.Abs(value);
            int length = a.ToString().Length;
            int[] array = new int[length];
            int[] newArray = new int[length];
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                array[i] = a % 10;
                a /= 10;
                newArray[i] += array[i]*Convert.ToInt32(Math.Pow(6,i));
                // Console.WriteLine(newArray[i]);

                
              
            }
              for(int x = 0;x<newArray.Length;x++)
                {
                    sum += newArray[x];
                }
            
            //4423 = 4*6^3 + 4*6^2 + 2*6^1 + 3*6^0 = 1023
            //864 + 144 + 12 + 3
            // double decima = array[0]*Math.Pow(6,0)+array[1]*Math.Pow(6,1)+array[2]*Math.Pow(6,2)+array[3]*Math.Pow(6,3);
            // int result = Convert.ToInt32(decima);
            return sum;
        }
    }
}

