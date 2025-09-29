//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap nam: ");
//        int nam = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Nhap thang: ");
//        int thang = Convert.ToInt32(Console.ReadLine());

//        switch (thang)
//        {
//            case 1:
//            case 3:
//            case 5:
//            case 7:
//            case 8:
//            case 10:
//            case 12:
//                Console.WriteLine("Thang co 31 ngay");
//                break;
//            case 4:
//            case 6:
//            case 9:
//            case 11:
//                Console.WriteLine("Thang co 30 ngay");
//                break;
//            case 2:
//                if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
//                    Console.WriteLine("Thang co 29 ngay");
//                else
//                    Console.WriteLine("Thang co 28 ngay");
//                break;
//            default:
//                Console.WriteLine("Thang khong hop le!");
//                break;
//        }
//    }
//}
