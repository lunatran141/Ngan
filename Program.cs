using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace baitapbuoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai1();         
            //Bai2();
            //Bai3();
            //Bai4();
            //Bai5();
            Bai6();
        }


        private static object Bai1()
        {
            /*Trong lập trình, kiểu dữ liệu float thường có độ chính xác giới hạn vì nó sử dụng một số bit nhất định 
             để lưu trữ một giá trị thập phân. Cụ thể, kiểu float theo chuẩn IEEE 754, sử dụng 32 bit để lưu trữ số thực, trong đó:

             1 bit dành cho dấu(positive/ negative).
             8 bit cho phần mũ(exponent).
             23 bit cho phần trị số(mantissa).
            Vì lý do đó, float chỉ có thể lưu trữ khoảng 6 - 7 chữ số thập phân chính xác.
            Khi bạn nhập một số thập phân có nhiều chữ số hơn, chỉ có các chữ số quan trọng nhất(từ đầu) 
            được lưu trữ một cách chính xác, còn các chữ số thập phân nhỏ hơn(ở phía xa bên phải) có thể bị làm tròn hoặc bỏ qua.

            Ví dụ:
            Khi bạn nhập số 3.14159265358979323812345678:

            float chỉ lưu trữ được 3.141593, làm tròn sau 6 chữ số thập phân.
            Giải pháp khi cần lưu trữ số thập phân có độ chính xác cao hơn:
            Nếu bạn cần làm việc với số thập phân có nhiều chữ số sau dấu phẩy, 
            có thể sử dụng kiểu double hoặc decimal(tuỳ thuộc vào ngôn ngữ lập trình), 
            vì các kiểu dữ liệu này có độ chính xác cao hơn so với float.

            Kiểu Double:

            Double sử dụng 64 bit để lưu trữ, giúp nó có thể lưu trữ khoảng 15 chữ số thập phân chính xác.
              Với số 3.14159265358979323812345678, double sẽ lưu trữ được chính xác là 3.141592653589793.
           Kiểu Decimal:

           Decimal thường được sử dụng trong các ứng dụng tài chính vì nó cung cấp độ chính xác rất cao, 
            có thể lưu trữ chính xác khoảng 28 - 29 chữ số thập phân.
           
            
            
            Với số 3.14159265358979323812345678, kiểu decimal có thể lưu trữ chính xác toàn bộ giá trị.

            Decimal là lựa chọn tốt nhất khi cần độ chính xác cao nhất trong các phép tính số thập phân lớn, 
            thường được sử dụng trong các tính toán tài chính.*/
            return Bai1();
        }
        private static object Bai2()
        {
            /*Nguyên nhân là do độ chính xác của số thực dấu phẩy động(floating-point) trong lập trình.
              Số thực dấu phẩy động không luôn được biểu diễn chính xác trong bộ nhớ máy tính.Khi bạn cộng 1.0f và 0.33f, 
            kết quả thực tế có thể khác một chút so với 1.33f do cách xử lý số thực của máy tính.

            Cụ thể:

            Kết quả của a +b có thể là 1.3300000000000001
            Trong khi giá trị của sum có thể chính xác là 1.33
            Vì sự sai lệch nhỏ này, phép so sánh a + b == sum sẽ trả về false, 
            mặc dù về mặt hiển thị thì chúng có vẻ giống nhau.
            
            Sửa lại là bỏ f khi cộng các số hoặc thêm chữ d(double) sau mỗi số.
            */
            return Bai2();
        }
        private static void Bai3()
        {

            string name;
            int birthdayYear = 0;
            bool isValid = false;

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            // Nhập tên
            Console.WriteLine("Nhập tên của bạn:");
            name = Console.ReadLine();

            // Vòng lặp kiểm tra năm sinh hợp lệ 
            while (!isValid)
            {
                Console.WriteLine("Nhập năm sinh của bạn:");
                string input = Console.ReadLine();
                // Sử dụng TryParse để kiểm tra năm sinh có phải là số nguyên hay không 
                if (int.TryParse(input, out birthdayYear))
                {
                    //Kiểm tra năm sinh có hợp lệ hay không 
                    if (birthdayYear > 1900 && birthdayYear <= DateTime.Now.Year)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Năm sinh không hợp lệ,vui lòng  nhập lại: ");
                    }
                }
                //Tính tuổi hiện tại 
                int currentYear = DateTime.Now.Year;
                int currentAge = currentYear - birthdayYear;

                // Tính tuổi vào năm 2000
                int ageIn2000 = 2000 - birthdayYear;
                // In kết quả  
                Console.WriteLine("\n  Kết quả");
                Console.WriteLine("Tên:" + name);
                Console.WriteLine("Năm sinh: " + birthdayYear);
                Console.WriteLine("Tuổi hiện tại:" + currentAge);

                // Kiểm tra xem năm 2000 có sau năm sinh không 
                if (ageIn2000 >= 0)
                {
                    Console.WriteLine("Tuổi vào năm 2000:" + ageIn2000);

                }
                else
                {
                    Console.WriteLine("Bạn chưa được sinh ra vào năm 2000 ");
                }

            }
        }
        private static void Bai4()
        {


            {
                double a = 0;
                double b = 0;
                bool isValidA = false;
                bool isValidB = false;

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                // Nhập hệ số a, kiểm tra giá trị hợp lệ
                while (!isValidA)
                {
                    Console.WriteLine("Nhập hệ số a (khác 0): ");
                    string inputA = Console.ReadLine();
                    if (double.TryParse(inputA, out a))
                    {
                        if (a != 0)
                        {
                            isValidA = true;
                        }
                        else
                        {
                            Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại.");
                    }
                }

                // Nhập hệ số b, kiểm tra giá trị hợp lệ
                while (!isValidB)
                {
                    Console.WriteLine("Nhập hệ số b: ");
                    string inputB = Console.ReadLine();
                    if (double.TryParse(inputB, out b))
                    {
                        isValidB = true;
                    }
                    else
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại.");
                    }
                }

                // Giải phương trình ax + b = 0 => x = -b / a
                double x = -b / a;

                // In ra kết quả với định dạng 5 chữ số lẻ phía sau
                Console.WriteLine("Nghiệm của phương trình là: X = {0:F5}", x);
            }
        }
        private static void Bai5()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // Khai báo các biến
            string hoTen;
            double chiSoCu = 0, chiSoMoi = 0, tieuThu = 0, tienDien = 0, phuThu = 0, tongTien = 0;
            const double donGia = 452.45;        // Đơn giá điện
            const int thueDienKe = 12426;        // Tiền thuê điện kế cố định
            const double phuThuTile = 0.1;       // Phụ thu 10%

            // Nhập họ tên khách hàng
            Console.Write("Nhập họ tên khách hàng: ");
            hoTen = Console.ReadLine();

            // Nhập chỉ số điện kế tháng trước và tháng này
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Nhập chỉ số cũ (tháng trước): ");
                if (double.TryParse(Console.ReadLine(), out chiSoCu) && chiSoCu >= 0)
                {
                    Console.Write("Nhập chỉ số mới (tháng này): ");
                    if (double.TryParse(Console.ReadLine(), out chiSoMoi) && chiSoMoi >= chiSoCu)
                    {
                        isValid = true; // Kiểm tra giá trị nhập hợp lệ
                    }
                    else
                    {
                        Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ. Vui lòng nhập lại.");
                    }
                }
                else
                {
                    Console.WriteLine("Chỉ số cũ phải là số không âm. Vui lòng nhập lại.");
                }
            }
            // Tính toán tiêu thụ điện
            tieuThu = chiSoMoi - chiSoCu;
            tienDien = tieuThu * donGia;
            phuThu = tienDien * phuThuTile;
            tongTien = tienDien + thueDienKe + phuThu;

            // In hóa đơn tiền điện
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hóa đơn tiền điện");
            Console.WriteLine("Khách hàng: {0}", hoTen);
            Console.WriteLine("Chỉ số cũ: {0}", chiSoCu);
            Console.WriteLine("Chỉ số mới: {0}", chiSoMoi);
            Console.WriteLine("Tiêu thụ: {0} kWh", tieuThu);
            Console.WriteLine("Tiền điện: {0:N0} đ", tienDien);
            Console.WriteLine("Tiền thuê điện kế: {0} đ/tháng", thueDienKe);
            Console.WriteLine("Tiền phụ thu (10% tiền điện): {0:N0} đ", phuThu);
            Console.WriteLine("Tổng tiền phải trả: {0:N0} đ", tongTien);
            Console.WriteLine("Yêu cầu tiết kiệm điện");
            Console.WriteLine("--------------------------------------------");
        }
        private static void Bai6()
        {

            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                string[] notes = { "Do", "Re", "Mi", "Fa", "Sol", "La", "Si" };
                string[] userChoices = { "d", "r", "m", "f", "o", "l", "s" };
                Random random = new Random();
                bool isRunning = true;

                while (isRunning)
                {
                    // Chọn ngẫu nhiên một nốt nhạc
                    int randomNoteIndex = random.Next(0, notes.Length);
                    string randomNote = notes[randomNoteIndex];
                    string expectedInput = userChoices[randomNoteIndex];

                    Console.WriteLine("Một nốt nhạc đã được chọn ngẫu nhiên. Hãy đoán xem đó là nốt gì!");
                    Console.WriteLine("Nhập Do (d), Re (r), Mi (m), Fa (f), Sol (o), La (l), Si (s) hoặc nhấn 't' để phát lại âm thanh: ");

                    while (true)
                    {
                        // Nhận nhập từ người dùng
                        string input = Console.ReadLine().ToLower();

                        // Kiểm tra nếu người dùng nhập 't' để phát lại nốt nhạc
                        if (input == "t")
                        {
                            Console.WriteLine("Phát lại nốt nhạc...");
                            continue;
                        }

                        // Kiểm tra nếu người dùng đoán đúng nốt nhạc
                        if (input == expectedInput)
                        {
                            Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng nốt nhạc: {randomNote}");
                            break; // Chạy nốt mới sau khi đoán đúng
                        }
                        else
                        {
                            Console.WriteLine("Sai rồi! Thử lại.");
                        }
                    }

                    // Tạo một nốt mới ngẫu nhiên hoặc hỏi người dùng có muốn chơi tiếp không
                    Console.WriteLine("Bạn có muốn tiếp tục chơi không? Nhấn 'y' để tiếp tục, phím bất kỳ để thoát.");
                    char tiepTuc = Console.ReadKey().KeyChar;
                    Console.WriteLine(); // Xuống dòng sau khi nhập
                    if (tiepTuc != 'y')
                    {
                        isRunning = false;
                    }
                }

                Console.WriteLine("Cảm ơn đã chơi!");
            }
        }

    }



   



}
    


   
