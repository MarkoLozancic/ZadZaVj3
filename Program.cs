using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadZaVj3
{
    class Sort
    {
       public void QuickSort(int[]arr,int left,int right)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
             arr[0]=left;
            arr[arr.Length -1]=right;
            return ;

        }
    }
    internal class Program
    {
        /*Definirajte klasu Sort sa sljedećim članicama:
• metoda
void QuickSort(int[] arr, int left, int right) koja će sortirati
proslijeñeni niz u uzlaznom redoslijedu
Definirajte objekt tipa Sort, deklarirajte i definirajte niz arr tipa int s proizvoljnim vrijednostima
elemenata, te uz pomoće metode QuickSort sortirajte niz tako da prvi i zadnji član niza bez
obzira na njihovu vrijednost ostanu na svojim mjestima.
Ispišite sve elemente niza.*/
        static void Main(string[] args)
        {
            int left, right;
            Sort sort = new Sort();
            int[] arr = {3,4,2,5,6,7,8,9,1};
            left = arr[0];
            right=arr[arr.Length - 1];
            sort.QuickSort(arr,left,right);
           
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

        }
    }
}
