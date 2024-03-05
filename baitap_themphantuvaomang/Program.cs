using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_themphantuvaomang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int N = int.Parse(Console.ReadLine());
            //khởi tạo 
            int[] arr = new int[N];
            //Nhập giá trị cho mảng
            Console.WriteLine("Nhap cac gia tri cho mang. Nhan Enter de ket thuc : ");
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                //Nhập giá trị là rỗng thì sẽ kết thúc nhập
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                arr[i] = int.Parse(input);

            }
            //Nhập giá trị của X từ bàn phím
            Console.WriteLine("Nhap gia tri cua X: ");
            int X = int.Parse(Console.ReadLine());
            int index;
            do
            {
                Console.WriteLine("Nhap vi tri cua X: ");
                index = int.Parse(Console.ReadLine());
                if (index < 0 || index > arr.Length)
                {
                    Console.WriteLine("Khong chen duoc phan tu vao mang. ");
                }
                else
                {
                    Console.WriteLine("Ta co mang moi la: ");  
                }  
            } while (index > N);
            // Tạo mảng mới lớn hơn mảng cũ để chứa X vừa nhập
            int[] newArr = new int[N + 1];
            // Chèn X vào mảng
            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[index] = X;
            for (int i = index; i < N; i++)
            {
                newArr[i + 1] = arr[i];
            }
            for (int i = 0; i <= N; i++)
            {

                Console.WriteLine(newArr[i] + " ");
            }
            Console.ReadKey();

        }
    }
}