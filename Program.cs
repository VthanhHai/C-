using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class chuongtrinh
    {
        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("Hello :))");
            int a = 1;
            Console.WriteLine(a);
            Console.WriteLine('a');//kí tự
            Console.WriteLine("abc");//chuỗi
            Console.WriteLine(true);
            Console.WriteLine(false);
            const string hi = "hello";
            Console.WriteLine(hi);
            // hi = "Xin chào"; // có const thì ko dc khai báo thêm.
            Console.WriteLine(hi);
            */
            // Lệnh nhập xuất.
            Console.WriteLine(" bạn tên gì ? ;");
            string name = Console.ReadLine();
            
           
            int yob = Convert.ToInt32(Console.ReadLine());
            int age = 2022 - yob;
            string noio= Console.ReadLine();
           Console.WriteLine("hello " + name + ", bạn được" + age +", nơi ở:"+ noio);
            
        }
        /*
        hàm dùng để so sanh 2 số nguyên.
        input: 2 số nguyên
        output:
        nếu a<b thì trả 1
        nếu a>b thì trả về 2
        ngược lại trả về 0
        // hải
        */
        int Compare(int a,int b)
        {
            return 1;
        }
    }
}

