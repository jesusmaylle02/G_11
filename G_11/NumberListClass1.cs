using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_11
{
    internal class NumberList
    {
        private List<int> numbers;

        public NumberList()
        {
            numbers = new List<int>();
        }

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public List<int> GetNumbers()
        {
            return numbers;
        }

        public void RemoveNumber(int number)
        {
            numbers.Remove(number);
        }

        public int SequentialSearch(int number)
        {
            return SequentialSearchRecursive(number, 0);
        }

        private int SequentialSearchRecursive(int number, int index)
        {
            if (index >= numbers.Count)
                return -1; // No encontrado
            if (numbers[index] == number)
                return index;
            return SequentialSearchRecursive(number, index + 1);
        }

        public void QuickSort()
        {
            QuickSortRecursive(0, numbers.Count - 1);
        }

        private void QuickSortRecursive(int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(left, right);
                QuickSortRecursive(left, pivotIndex - 1);
                QuickSortRecursive(pivotIndex + 1, right);
            }
        }

        private int Partition(int left, int right)
        {
            int pivot = numbers[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (numbers[j] <= pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }
            Swap(i + 1, right);
            return i + 1;
        }

        private void Swap(int a, int b)
        {
            int temp = numbers[a];
            numbers[a] = numbers[b];
            numbers[b] = temp;
        }

        public void SortAscending()
        {
            QuickSort();
        }

        public void SortDescending()
        {
            QuickSort();
            numbers.Reverse();
        }

        public void PrintNumbers()
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
