using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp4
{
    public class Sort
    {
        private int[] Arr;
        private int Index;
      
        private Sort(int[] arr, int index)
        {
            Arr = arr;
            Index = index;
        }

        private static void Swap(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }

        static int GetNextStep(int step)
        {
            step = step * 1000 / 1247;
            return step > 1 ? step : 1;
        }

        public static int[] ComboSort(int[] array)
        {
            int currentStep = array.Length - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < array.Length; i++)
                {
                    if (array[i] > array[i + currentStep])
                    {
                        Swap(ref array[i], ref array[i + currentStep]);
                    }
                }

                currentStep = GetNextStep(currentStep);
            }

            BubbleSort(array);
            return array;
        }

        private static void BubbleSort(int[] array)
        {
            int arrayLength = array.Length;

            for (int i = 1; i < arrayLength; i++)
            {
                bool swapFlag = false;

                for (int j = 0; j < arrayLength - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
        }

        static int SelectId(int[] array, int valueForTheSearch)
        {
            foreach (int i in array)
            {
                for (int j = 1; j < array.Length; j++)
                    if (i == valueForTheSearch)
                    {
                        return i;
                    }
            }
            return 0;
        }

        public int[] ShillSort(int[] array, int size)
        {
            for (int Size = size / 2; Size > 0; Size /= 2)
            {
                for (int i = Size; i < size; i++)
                {
                    int elem = array[i];
                    int j = i;
                    while (j >= Size && array[j - Size] > elem)
                    {
                        array[j] = array[j - Size];
                        j -= Size;
                    }
                    array[j] = elem;
                }
            }
            return array;
        }

        static string Print(int[] array)
        {
            return string.Join(" ", array);
        }
    }
}
