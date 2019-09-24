using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM.ProyectoEDO.DAO
{
    public class Orden
    {
        public Orden()
        { }

        private int[] vector;
        int tem;

        public int[] bubbleSort(int[] nDesordenados)
        {
            vector = nDesordenados;
            for (int pasadas = 1; pasadas < vector.Length; pasadas++)
            {
                for (int i = vector.Length - 1; i >= pasadas; i--)
                {
                    if (vector[i - 1] > vector[i])
                    {
                        tem = vector[i - 1];
                        vector[i - 1] = vector[i];
                        vector[i] = tem;
                    }
                }
            }
            return vector;
        }

        public int[] selectionSort(int[] nDes)
        {
            vector = nDes;
            int i, j, min, temp;
            for (i = 0; i < vector.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < vector.Length; j++)
                {
                    if (vector[j] < vector[min])
                    {
                        min = j;
                    }
                }
                temp = vector[i];
                vector[i] = vector[min];
                vector[min] = temp;
            }
            //int maxIndex, temp;
            //for (int i = vector.Length - 1; i > 0; i--)
            //{
            //    maxIndex = 0;

            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (vector[j] > vector[maxIndex])
            //            maxIndex = j;
            //    }
            //    temp = vector[maxIndex];
            //    vector[maxIndex] = vector[i];
            //    vector[i] = temp;
            //}
            return vector;
        }

        public int[] shakerSort(int[] nDeso)
        {
            vector = nDeso;

            for (int k = vector.Length - 1; k > 0; k--)
            {
                bool swapped = false;
                for (int i = k; i > 0; i--)
                    if (vector[i] < vector[i - 1])
                    {
                        // swap
                        int temp = vector[i];
                        vector[i] = vector[i - 1];
                        vector[i - 1] = temp;
                        swapped = true;
                    }

                for (int i = 0; i < k; i++)
                    if (vector[i] > vector[i + 1])
                    {
                        // swap
                        int temp = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = temp;
                        swapped = true;
                    }

                if (!swapped)
                    break;
            }
            //for (int p = 1; p <= vector.Length / 2; p++)
            //{
            //    for (int i = p - 1; i < vector.Length - p; i++)
            //    {
            //        if (vector[i].CompareTo(vector[i + 1]) > 0)
            //        {
            //            //MyMath.swap(vector, i, i + 1);
            //        }
            //    }

            //    for (int i = vector.Length - p - 1; i >= p; i--)
            //    {
            //        if (vector[i].CompareTo(vector[i - 1]) < 0)
            //        {
            //            //MyMath.swap(a, i, i - 1);
            //        }
            //    }
            //}
            return vector;
        }

        public int[] quickSort(int[] nDesOr)
        {
            vector = nDesOr;
            qs(vector, 0, vector.Length - 1);
            return vector;
        }

        public void qs(int[] x, int left, int right)
        {
            int i, j;
            int pivot, temp;

            i = left;
            j = right;
            pivot = x[(left + right) / 2];

            do
            {
                while ((x[i] < pivot) && (i < right)) i++;
                while ((pivot < x[j]) && (j > left)) j--;

                if (i <= j)
                {
                    temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    i++; j--;
                }
            } while (i <= j);

            if (left < j) qs(x, left, j);
            if (i < right) qs(x, i, right);
        }

        public int[] heapSort(int[] r)
        {
            vector = r;
            int t;
            for (int i = 5; i >= 0; i--)
            {
                adjust(vector,i, 9);
            }
            for (int i = 8; i >= 0; i--)
            {
                t = r[i + 1];
                r[i + 1] = r[0];
                r[0] = t;
                adjust(vector, 0, i);
            }
            return vector;
        }

        private void adjust(int[] r, int i, int n)
        {
            int t, j;

            t = r[i];
            j = 2 * i;
            while (j <= n)
            {
                if (j < n && r[j] < r[j + 1])
                    j++;
                if (t >= r[j])
                    break;
                r[j / 2] = r[j];
                j *= 2;
            }
            r[j / 2] = t;
        }
    }
}