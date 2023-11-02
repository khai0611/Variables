using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int KieuSoNguyen = 10;
            string name = "QK";

            //In giá trị của biến KieuSoNguyen ra màn hình => kết quả là 10
            Console.WriteLine(KieuSoNguyen);
            //In giá trị của biến name ra màn hình => kết quả là QK
            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}

//Biến là gì
//Biến => Có thể thay đổi
/*
Biến:
- Là một giá trị dữ liệu có thể thay đổi được
- Là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ
- Là thành phần cốt lõi của một ngôn ngữ lập trình 
Cú pháp:
- <kiểu dữ liệu> <tên biến>;
VD: int a;
Quy tắc đặt tên biến
- Tên biến là một chuỗi ký tự liên kết (không có khoảng trắng) và không chứa ký tự đặc biệt
- Tên biến không được đặt bằng tiếng Việt có dấu
- Tên biến không được bắt đầu bằng số
- Tên biến không được trùng nhau
- Tên biến không được trùng với từ khóa (VD: abstract, default, for, bool, base, break,...)
*/