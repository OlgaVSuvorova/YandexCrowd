using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace YandexCrowd // 
{
    public class PowerOfTwo
    {
        
        public int GetBiggerPowerOfTwo(int number)
        {
            if (number == 1)
             return 1;
            int power = 1;
            int currentNumber = 2;
            while (currentNumber < number)
            {
                power++;
                currentNumber *= 2;
            }
            return power;
        }

        
    }

    public class ArrayOfInt
    {
        int[] data;

        public ArrayOfInt(int maxNumber, int capacity)
        {
            Random rnd = new Random();
            data = new int[capacity];
            for (int i = 0; i< data.Length; i++)
            {
                data[i] = rnd.Next(0, maxNumber);
            }
        }

        public int[] GetData()
        {
            return data;
        }

        public int GetDataSum()
        {
            int sum = 0;
            for (int i = 0; i< data.Length; i++)
            {
                sum += data[i];
            }
            return sum;
        }
    }


}