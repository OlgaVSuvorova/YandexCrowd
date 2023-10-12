using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace YandexCrowd // 
{
    class PrimeNumbers
    {
        List<int> primeNumbers;
        int maxNumber;
        int iterations = 0;
        
        public List<int> FindPrimeNumbers(int maxNumber)
        {
            this.maxNumber = maxNumber;
            primeNumbers = new List<int>();

            if (!checkStartNums())
                return primeNumbers;

            SkipNumbers skipNumbers = new SkipNumbers(7);
           
            for (int i = 7; i <= maxNumber; i++)
            {
                iterations++;
                if (!skipNumbers.IsSkippedNumber())
                {
                    if (isPrimeNumber(i))
                    {
                        primeNumbers.Add(i);
                    }
                }
                
                skipNumbers.NextNumber();
            }
                            
            return primeNumbers;
        }

        private bool isPrimeNumber(int number)
        {
            SkipNumbers skipNumbers = new SkipNumbers(7);
            for (int i = 2; i < (int)number/4; i++) //ищем делители до половины числа
            {
                iterations++;
                if (!skipNumbers.IsSkippedNumber())
                {
                    if ((number % i) == 0)
                        return false;
                }
                skipNumbers.NextNumber();
            }
            return true;
        }

        //better start with 7, but may be max number is less
        private bool checkStartNums()
        {
            if (maxNumber > 0)
            {
                primeNumbers.Add(1);
                if (maxNumber >  1)
                {
                    primeNumbers.Add(2);
                    if (maxNumber > 2)
                    {
                        primeNumbers.Add(3);
                        if (maxNumber > 4)
                        {
                            primeNumbers.Add(5);
                            if (maxNumber > 6) //start with 7
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        public int GetIterations()
        {
                return iterations;
        }

        private class SkipNumbers
        {
            int counter2 = 0; //divisible by 2, skip them
            int counter3 = 0; //divisible by 3, skip them
            int counter5 = 0; //divisible by 5, skip them

            public SkipNumbers(int startNumber)
            {
                counter2 = startNumber%2;
                counter3 = startNumber%3;
                counter5 = startNumber%5;
            }

            public void NextNumber()
            {
                counter2++;
                counter3++;
                counter5++;
                if (counter2 == 2)
                    counter2 = 0;
                if (counter3 == 3)
                    counter3 = 0;
                if (counter5 == 5)
                    counter5 = 0;

            }

            public bool IsSkippedNumber()
            {
                if (counter2 == 0 || counter3 == 0 || counter5 == 0)
                    return true;
                return false;
            }
        }
    }
}
