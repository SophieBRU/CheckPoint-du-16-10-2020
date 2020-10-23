using System;

namespace CheckPoint_du_16._10._2020___Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integer = new int[4] { 4, 3, 2, 1 };

            SortedArray sortedArray = new SortedArray();

            sortedArray.SetArray(integer);
            Console.WriteLine("Tableau d'origine :");
            sortedArray.GetArray();
            sortedArray.BubbleSort(integer);
            Console.WriteLine("Tableau trié :");
            sortedArray.GetArray();

        }
        class SortedArray
        {
            private int[] _integerArray;
            public void GetArray()
            {
                foreach (int value in _integerArray)
                {
                    Console.WriteLine(value);
                }
            }
            public void SetArray(int[] integer)
            {
                _integerArray = integer;
            }

            public int[] BubbleSort(int[] _integerArray)
            {
                for (int j = 0; j <= _integerArray.Length - 2; j++)
                {
                    for (int i = 0; i <= _integerArray.Length - 2; i++)
                    {
                        if (_integerArray[i] > _integerArray[i + 1])
                        {
                            int temp = _integerArray[i + 1];
                            _integerArray[i + 1] = _integerArray[i];
                            _integerArray[i] = temp;
                        }
                    }
                }
                return _integerArray;
            }
        }
    }
}



