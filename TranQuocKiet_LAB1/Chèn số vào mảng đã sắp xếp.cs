//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 1, 3, 5, 7, 9 };
//        Console.Write("Nhap so can chen: ");
//        int x = Convert.ToInt32(Console.ReadLine());

//        int n = arr.Length;
//        int[] newArr = new int[n + 1];
//        int i = 0, j = 0;
//        bool inserted = false;

//        while (i < n)
//        {
//            if (!inserted && x < arr[i])
//            {
//                newArr[j++] = x;
//                inserted = true;
//            }
//            newArr[j++] = arr[i++];
//        }

//        if (!inserted) newArr[j] = x;

//        Console.WriteLine("Mang sau khi chen:");
//        foreach (int val in newArr)
//            Console.Write(val + " ");
//    }
//}
