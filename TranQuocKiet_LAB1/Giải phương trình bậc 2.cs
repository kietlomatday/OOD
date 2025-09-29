//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap a: ");
//        double a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Nhap b: ");
//        double b = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Nhap c: ");
//        double c = Convert.ToDouble(Console.ReadLine());

//        if (a == 0)
//        {
//            if (b == 0)
//            {
//                Console.WriteLine(c == 0 ? "Phuong trinh vo so nghiem" : "Phuong trinh vo nghiem");
//            }
//            else
//            {
//                Console.WriteLine("Phuong trinh co nghiem x = " + (-c / b));
//            }
//        }
//        else
//        {
//            double delta = b * b - 4 * a * c;
//            if (delta < 0)
//                Console.WriteLine("Phuong trinh vo nghiem");
//            else if (delta == 0)
//                Console.WriteLine("Phuong trinh co nghiem kep x = " + (-b / (2 * a)));
//            else
//            {
//                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//                Console.WriteLine("Phuong trinh co 2 nghiem: x1 = " + x1 + ", x2 = " + x2);
//            }
//        }
//    }
//}
