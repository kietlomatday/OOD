//using System;
//using System.IO;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Bước 1: Đọc dữ liệu từ file input_array.txt
//        string path = "input_array.txt";

//        if (!File.Exists(path))
//        {
//            Console.WriteLine("Không tim thay file input_array.txt");
//            return;
//        }

//        // Đọc toàn bộ nội dung file
//        string content = File.ReadAllText(path);

//        // Tách thành mảng số nguyên
//        int[] arr = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
//                           .Select(int.Parse)
//                           .ToArray();

//        Console.WriteLine("Mang ban đau:");
//        Console.WriteLine(string.Join(" ", arr));

//        // Bước 2: Selection Sort
//        int n = arr.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            int minIdx = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if (arr[j] < arr[minIdx])
//                    minIdx = j;
//            }

//            // Hoán đổi phần tử nhỏ nhất với arr[i]
//            int temp = arr[minIdx];
//            arr[minIdx] = arr[i];
//            arr[i] = temp;
//        }

//        // Bước 3: Xuất kết quả
//        Console.WriteLine("Mang sau khi sap xep tang dan:");
//        Console.WriteLine(string.Join(" ", arr));
//    }
//}
