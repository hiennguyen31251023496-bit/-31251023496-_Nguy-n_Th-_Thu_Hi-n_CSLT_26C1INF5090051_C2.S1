using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION03
{
    enum Currency
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4
    }
    enum loaidiem
    {
        None,
        A,
        B,
        C,
        D,
        F
    }
    enum StockStatus
    {
        InStock,
        LowStock,
        OutOfStock,
        Discontinued
    }
    internal class BT_DATA_TYPES
    {

        static void BAI_1()
        {
            Console.WriteLine("\t BÀI 1:Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang (EVN)");
            decimal csd_cu;
            do
            {
                Console.Write("Nhập chỉ số điện cũ (kWh): ");
                csd_cu = decimal.Parse(Console.ReadLine());

                if (csd_cu >= 0)
                    break;
                else
                    Console.WriteLine("\t Chỉ số cũ phải lớn hơn hoặc bằng 0. Vui lòng nhập lại.");
            } while (true);

            decimal csd_moi;
            do
            {
                Console.Write("Nhập chỉ số điện mới(Kwh): ");
                csd_moi = decimal.Parse(Console.ReadLine());
                if (csd_moi < csd_cu)
                    Console.WriteLine("\tChỉ số điện mới phải lớn hơn chỉ số điện cũ. Vui lòng nhập lại.");
                else
                    break;
            } while (true);
            decimal so_dien_tieu_thu = csd_moi - csd_cu;
            decimal tienchuathue = 0;
            decimal kwh = so_dien_tieu_thu;
            if (kwh > 0)
            {
                decimal bac1 = Math.Min(kwh, 50);
                tienchuathue += bac1 * 1806m;
                kwh -= bac1;
            }
            if (kwh > 0)
            {
                decimal bac2 = Math.Min(kwh, 50);
                tienchuathue += bac2 * 1866m;
                kwh -= bac2;
            }
            if (kwh > 0)
            {
                decimal bac3 = Math.Min(kwh, 100);
                tienchuathue += bac3 * 2167m;
                kwh -= bac3;
            }
            if (kwh > 0)
            {
                decimal bac4 = Math.Min(kwh, 100);
                tienchuathue += bac4 * 2729m;
                kwh -= bac4;
            }
            if (kwh > 0)
            {
                tienchuathue += kwh * 3050m;
            }
            decimal thueVAT = Math.Round(tienchuathue * 0.08m, MidpointRounding.AwayFromZero);
            decimal tongthanhtoan = tienchuathue + thueVAT;
            Console.WriteLine($"Số điện tiêu thụ: {so_dien_tieu_thu} Kwh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienchuathue:#,##0} VND");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT:#,##0} VND");
            Console.WriteLine($"Tổng thanh toán: {tongthanhtoan:#,##0} VND");
        }
        static void BAI_2()
        {
            Console.WriteLine("\t BÀI 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe");
            // 1. Nhập và kiểm tra tính hợp lệ của chiều cao
            double chieu_cao;
            while (true)
            {
                Console.Write("Nhập chiều cao(m):");
                string? inputH = Console.ReadLine();
                bool isSuccessH = double.TryParse(inputH, CultureInfo.InvariantCulture, out chieu_cao);
                if (isSuccessH && chieu_cao <= 3.0)
                {
                    break;
                }
                Console.WriteLine("Chiều cao không hợp lệ. Vui lòng nhập lại.");
            }
            // 2. Nhập và kiểm tra tính hợp lệ của cân nặng
            double can_nang;
            while (true) 
            {
                 Console.Write("Nhập cân nặng(kg):");
                 string? inputW = Console.ReadLine();
                 bool isSuccessW = double.TryParse(inputW, CultureInfo.InvariantCulture, out can_nang);
                 if (isSuccessW && can_nang <= 500.0)
                 {
                     break;
                 }
                    Console.WriteLine("Cân nặng không hợp lệ. Vui lòng nhập lại.");
            }
            // 3. Tính chỉ số BMI và cân loại lý tưởng
            double bmi = can_nang / Math.Pow(chieu_cao, 2);
            double min_ideal_weight = 18.5 * Math.Pow(chieu_cao, 2);
            double max_ideal_weight = 22.9 * Math.Pow(chieu_cao, 2);
            // 4. Phân loại tình trạng sức khỏe
            string health_status = string.Empty;
            if (bmi < 18.5)
            {
                health_status = "Gầy";
            }
            else if (bmi < 23.0)
            {
                health_status = "Bình thường";
            }
            else if (bmi < 25.0)
            {
                health_status = "Thừa cân";
            }
            else
            {
                health_status = "Béo phì";
            }
            // 5. Hiển thị kết quả
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {health_status}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {min_ideal_weight:F2} kg đến {max_ideal_weight:F2} kg.");
            Console.ReadKey();
        }
        static void BAI_3()
        {   
            Console.WriteLine("\t BÀI 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng");
            
            // Khai báo tỷ giá ngân hàng
            const decimal USD_TO_VND = 25400m;
            const decimal EUR_TO_VND = 27200m;
            const decimal JPY_TO_VND = 165m;
            const decimal GBP_TO_VND = 32100m;
            // Nhập số tiền và loại tiền tệ từ người dùng
            decimal so_tien=0m;
            while (true)
            {
                Console.Write("Nhập số tiền VNĐ: ");
                string? inputVND = Console.ReadLine();
                bool isSuccessVND = decimal.TryParse(inputVND, NumberStyles.Any, CultureInfo.InvariantCulture, out so_tien);
                if (isSuccessVND && so_tien > 0)
                {
                    break;
                }
                Console.WriteLine("Số tiền không hợp lệ. Vui lòng nhập lại.");
            }
            int choice=0;
            while (true)
            {
                Console.Write("Chọn loại tiền tệ để quy đổi(1-USD, 2-EUR, 3-JPY, 4-GBP): ");
                string? inputChoice = Console.ReadLine();
                bool isSuccessChoice = int.TryParse(inputChoice, out choice);
                if (isSuccessChoice && choice >= 1 && choice <= 4)
                {
                    break;
                }
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập từ số từ 1-4.");
            }
                //Ép kiểu sang enum Currency
                Currency selectedCurrency = (Currency)choice;
                // Quy đổi tiền tệ dựa trên lựa chọn của người dùng
                decimal rate = 0m;
                string currencyName = string.Empty;
                switch (selectedCurrency)
                {
                    case Currency.USD:
                        rate = USD_TO_VND;
                        currencyName = "USD";
                        break;
                    case Currency.EUR:
                        rate = EUR_TO_VND;
                        currencyName = "EUR";
                        break;
                    case Currency.JPY:
                        rate = JPY_TO_VND;
                        currencyName = "JPY";
                        break;
                    case Currency.GBP:
                        rate = GBP_TO_VND;
                        currencyName = "GBP";
                        break;
                }
        decimal PhiDV = so_tien * 0.005m; // Phí dịch vụ 0.5%
        decimal VND_after_fee = so_tien - PhiDV; // Số tiền sau khi trừ phí dịch vụ
        decimal so_tien_quy_doi = VND_after_fee / rate; // Số tiền quy đổi sang ngoại tệ
        // Hiển thị kết quả
        Console.WriteLine($"Phí dịch vụ (0.5%): {PhiDV:#,##0} VND");
        Console.WriteLine($"Số tiền VNĐ tính đổi: {VND_after_fee:#,##0} VND");
        Console.WriteLine($"Số tiền { currencyName} nhận được: {so_tien_quy_doi:#,##0.00} {currencyName}");
        }
        static void BAI_4()
        {
            Console.WriteLine("\t BÀI 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật");
            DateTime birthDate;
            DateTime today = DateTime.Now.Date; // Lấy ngày hiện tại, bỏ phần thời gian
            // Nhập ngày sinh từ người dùng và kiểm tra tính hợp lệ
            while (true)
            {
                Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy): ");
                string? inputDate = Console.ReadLine();
                //Dùng DateTime.TryParseExact để kiểm tra định dạng ngày nhập vào
                bool isSuccess = DateTime.TryParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
                if (isSuccess && birthDate <= today)
                {
                    break;
                }
                Console.WriteLine("Ngày sinh không hợp lệ hoặc lớn hơn ngày hiện tại. Vui lòng nhập lại.");
            }
            // Tính tuổi chính xác
            int age = today.Year - birthDate.Year;
            // Kiểm tra xem sinh nhật đã qua chưa
            if (today < birthDate.AddYears(age))
            {
                age--;
            }
            // Tính số ngày đã sống
         TimeSpan livedSpan = today - birthDate;
         int livedDays = (int)livedSpan.TotalDays;
            // Tính số ngày còn lại đến sinh nhật tiếp theo
           DateTime nextBirth = new DateTime(today.Year, birthDate.Month, birthDate.Day);
           if (nextBirth < today)
            {
                nextBirth = nextBirth.AddYears(1);
            }
           TimeSpan daysUntilNext = nextBirth - today;
           int daysRemaining = (int)daysUntilNext.TotalDays;
            // Hiển thị kết quả 
            Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {livedDays} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {daysRemaining} ngày");
        }
        static void BAI_5()
        {
            Console.WriteLine("Bài 5: Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA (4.0)");
        // Nhập điểm số và kiểm tra tính hợp lệ
        double Csharp, toan, tienganh;
            while (true)
            {
                Console.Write("C# (4TC): ");
                string? inputCsharp = Console.ReadLine();
                bool isSuccessCsharp = double.TryParse(inputCsharp, NumberStyles.Any, CultureInfo.InvariantCulture, out Csharp);
                if (isSuccessCsharp && Csharp >= 0 && Csharp <= 10)
                {
                    break;
                }
                Console.WriteLine("Điểm C# không hợp lệ. Vui lòng nhập lại.");
            }
            while (true)
            {
                Console.Write("Toán (3TC): ");
                string? inputToan = Console.ReadLine();
                bool isSuccessToan = double.TryParse(inputToan, NumberStyles.Any, CultureInfo.InvariantCulture, out toan);
                if (isSuccessToan && toan >= 0 && toan <= 10)
                {
                    break;
                }
                Console.WriteLine("Điểm Toán không hợp lệ. Vui lòng nhập lại.");
            }
            while (true)
            {
                Console.Write("Tiếng Anh (2TC): ");
                string? inputTiengAnh = Console.ReadLine();
                bool isSuccessTiengAnh = double.TryParse(inputTiengAnh, NumberStyles.Any, CultureInfo.InvariantCulture, out tienganh);
                if (isSuccessTiengAnh && tienganh >= 0 && tienganh <= 10)
                {
                    break;
                }
                Console.WriteLine("Điểm Tiếng Anh không hợp lệ. Vui lòng nhập lại.");
            }
            // Tính điểm trung bình thang 10, GPA thang 4.0 và xếp loại học lực
            int tcCsharp = 4;
            int tcToan = 3;
            int tcTiengAnh = 2;
            double GPA;
            string hocluc;
            loaidiem xeploai = loaidiem.None;
            double diemTB10 = (Csharp * tcCsharp + toan * tcToan + tienganh * tcTiengAnh) / (tcCsharp + tcToan + tcTiengAnh);
            // Quy đổi điểm trung bình thang 10 sang GPA thang 4.0 và xếp loại học lực  
            if (diemTB10 >= 8.5)
            {
                GPA = 4.0;
                hocluc = "Xuất sắc/Giỏi";
                xeploai = loaidiem.A;
            }
            else if (diemTB10 >= 7.0)
            {
                GPA = 3.0;
                hocluc = "Khá";
                xeploai = loaidiem.B;
            }
            else if (diemTB10 >= 5.5)
            {
                GPA = 2.0;
                hocluc = "Trung bình";
                xeploai = loaidiem.C;
            }
            else if (diemTB10 >= 4.0)
            {
                GPA = 1.0;
                hocluc = "Yếu";
                xeploai = loaidiem.D;
            }
            else
            {
                GPA = 0.0;
                hocluc = "Kém (Trượt)";
                xeploai = loaidiem.F;

            }
        Console.WriteLine($"Điểm trung bình thang 10: {diemTB10:F2}");
        Console.WriteLine($"Điểm chữ quy đổi: {xeploai}");
        Console.WriteLine($"Điểm GPA thang 4.0: {GPA:F1}");
        Console.WriteLine($"Xếp loại học lực: {hocluc}");

        }
        static void BAI_6()
        {
            Console.WriteLine("Bài 6: Quản Lý Thông Tin Sinh Viên");            
        }
        static void BAI_7()
        {
            Console.WriteLine("\t Bài 7: Lập Kế Hoạch Chi Phí Nhiên Liệu & Chia Sẻ Chuyến Đi (Car-pooling)");
            Console.Write("Quãng đường (km): ");
            double quangDuong = double.Parse(Console.ReadLine());
            Console.Write("Mức tiêu hao (L/100km): ");
            double mucTieuHao = double.Parse(Console.ReadLine());
            Console.Write("Giá xăng(VND/L): ");
            decimal giaXang = decimal.Parse(Console.ReadLine());
            Console.Write("Số người đi: ");
            int soNguoi = int.Parse(Console.ReadLine());
            //Tính toán số lượng xăng tiêu thụ, chi phí nhiên liệu và chi phí chia sẻ
            double soLuongXang = (quangDuong * mucTieuHao) / 100;
            decimal tongChiPhi = (decimal)soLuongXang * giaXang;
            decimal chiphimoinguoi = tongChiPhi / (decimal)soNguoi;
            decimal chiphimoinguoiLamTron = Math.Ceiling(chiphimoinguoi/1000m) * 1000m; // Làm tròn lên đến nghìn đồng gần nhất
            // Hiển thị kết quả
            Console.WriteLine($"Tổng nhiên liệu thiêu thụ: {soLuongXang:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi}");
            Console.WriteLine($"Chi phí mỗi người: {chiphimoinguoiLamTron}");
        }
        static void BAI_8()
        {
            Console.WriteLine("Bài 8: Kiểm Tra Mã Xác Thực OTP & Quản Lý Thời Gian Hiệu Lực ");
            string correctOTP = "839201"; // Mã OTP đúng
            DateTime CreationTime = DateTime.Now; // Thời gian tạo OTP
            Console.Write("Mã OTP nhận được:");
            string? inputOTP = Console.ReadLine();
            DateTime submitTime = DateTime.Now; // Thời gian người dùng nhập OTP
            TimeSpan timelapsed = submitTime - CreationTime; // Tính thời gian trôi qua
            Console.WriteLine($"Thời gian trôi qua: {timelapsed.Minutes} phút {timelapsed.Seconds} giây");
            // Kiểm tra OTP và thời gian hiệu lực
            bool isOTPValid = !string.IsNullOrEmpty(inputOTP) && inputOTP.Length == 6 && int.TryParse(inputOTP, out _);
            if (!isOTPValid)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI- Định dậng không hợp lệ (Mã OTP phải gồm 6 chữ số)");
            }
            if (timelapsed.Minutes > 5)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI- Mã OTP đã hết hạn (hết 5 phút)");
            }
            if (inputOTP == correctOTP)
            {
                Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG- Mã OTP hợp lệ");
            }
            else
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI- Mã OTP không đúng");

            }
        }
        static void BAI_9()
        {
            Console.WriteLine("Bài 9: Máy Tính Lương Gross - Net & Thuế TNCN Nhân Viên");
            //Mức giảm trừ và tỷ lệ bảo hiểm
            const decimal InsuaranceRate = 0.105m; // 8% BHXH + 1.5% BHYT + 1% BHTN
            const decimal PersonalDeduction = 11000000m; // Mức giảm trừ gia cảnh cá nhân
            const decimal DependentDeduction = 4400000m; // Mức giảm trừ gia cảnh cho mỗi người phụ thuộc
            // Nhập lương gross từ người dùng và số người phụ thuộc, kiểm tra tính hợp lệ
            decimal grossSalary;
            int dependents;
            while (true)
            {
                Console.Write("Nhập lương gross (VND): ");
                string? inputGross = Console.ReadLine();
                bool isSuccessGross = decimal.TryParse(inputGross, NumberStyles.Any, CultureInfo.InvariantCulture, out grossSalary);
                if (isSuccessGross && grossSalary > 0)
                {
                    break;
                }
                Console.WriteLine("Lương gross không hợp lệ. Vui lòng nhập lại.");
            }
            while (true)
            {
                Console.Write("Nhập số người phụ thuộc: ");
                string? inputDependents = Console.ReadLine();
                bool isSuccessDependents = int.TryParse(inputDependents, out dependents);
                if (isSuccessDependents && dependents >= 0)
                {
                    break;
                }
                Console.WriteLine("Số người phụ thuộc không hợp lệ. Vui lòng nhập lại.");

            }
            //Giảm trừ bảo hiểm
            decimal totalInsuarance = grossSalary * InsuaranceRate;
            //Tổng giảm trừ
            decimal totalDeduction = PersonalDeduction + (DependentDeduction * dependents) + totalInsuarance;
            // Thu nhập chịu thuế = lương gross - tổng giảm trừ
            decimal taxableIncome = grossSalary - totalDeduction;
            //Kiểm tra thu nhập chịu thuế
            if (taxableIncome < 0m)
            {
                taxableIncome = 0m;
            }
            decimal TNCNtax = 0m;
            decimal remainingIncome = taxableIncome;
            // Tính thuế TNCN theo biểu thuế lũy tiến từng phần
            if (remainingIncome > 0m)
            {
                decimal bac1 = Math.Min(remainingIncome, 5000000m);
                TNCNtax += bac1 * 0.05m;
                remainingIncome -= bac1;
            }
            if (remainingIncome > 0m)
            {
                decimal bac2 = Math.Min(remainingIncome, 5000000m);
                TNCNtax += bac2 * 0.10m;
                remainingIncome -= bac2;
            }
            if (remainingIncome > 0m)
            {
                decimal bac3 = Math.Min(remainingIncome, 8000000m);
                TNCNtax += bac3 * 0.15m;
                remainingIncome -= bac3;
            }
            if (remainingIncome > 0m)
            {
                decimal bac4 = Math.Min(remainingIncome, 14000000m);
                TNCNtax += bac4 * 0.20m;
                remainingIncome -= bac4;
            }
            if (remainingIncome > 0m)
            {
                decimal bac5 = Math.Min(remainingIncome, 20000000m);
                TNCNtax += bac5 * 0.25m;
                remainingIncome -= bac5;
            }
            if (remainingIncome > 0m)
            {
                decimal bac6 = Math.Min(remainingIncome, 28000000m);
                TNCNtax += bac6 * 0.30m;
                remainingIncome -= bac6;
            }
            if (remainingIncome > 0m)
            {
                TNCNtax += remainingIncome * 0.35m;
            }
            decimal netSalary = grossSalary - totalInsuarance - TNCNtax;
            // Hiển thị kết quả
            Console.WriteLine($"Giảm trừ bảo hiểm (10.5%): {totalInsuarance:#,##0} VND");
            Console.WriteLine($"Thu nhập chịu thuế: {taxableIncome:#,##0} VND");
            Console.WriteLine($"Thuế TNCN phải nộp: {TNCNtax:#,##0} VND");
            Console.WriteLine($"Lương NET thực nhận: {netSalary:#,##0} VND");
        }
        static void BAI_10()
        {
            Console.WriteLine("Bài 10: Quản Lý Tồn Kho & Xử Lý Giá Trị Khuyết Thiếu (Nullable Types)");
            //Khai báo thông tin sản phẩm
            string productName = "Bàn phím cơ Akko";
            string productCode = "KB-09";
            int? quantity = null; // Số lượng tồn kho có thể là null
            int minThreshold = 10; //Ngưỡng tồn kho an toàn
            DateTime? restockDate = null; // Ngày nhập kho có thể là null
            //Giả lập dữ liệu đầu vào
            Console.WriteLine($"Sản phẩm: {productName} (Mã: {productCode})");
            Console.WriteLine($"Số lượng tồn kho: {(quantity.HasValue ? quantity.Value.ToString() : "null (Chưa kiểm kê)")}");
            Console.WriteLine($"Restock Date:{(restockDate.HasValue ? restockDate.Value.ToString("dd/MM/yyyy") : "null")}");
            //Xử lý số lượng hiển thị vâ
            int displayQuantity = quantity ?? 0; // Nếu quantity là null, hiển thị 0
            string warningText = (quantity == null) ? "(Cảnh báo: Dữ liệu trống)" : "";
            //Đánh giá trạng thái kho
            StockStatus status;
            string statusText;
            if (quantity == null || quantity == 0)
            {
                status = StockStatus.OutOfStock;
                statusText = "Hết hàng";
            }
            else if (quantity < 10)
            {
                status = StockStatus.LowStock;
                statusText = "Sắp hết hàng";

            }
            else
            {
                status = StockStatus.InStock;
                statusText = "Còn hàng";
            }
            //Xử lý ngày nhập
            string restockDisplay = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";
            // Hiển thị kết quả
            Console.WriteLine($"Số lượng hiển thị: {displayQuantity}{warningText}");
            Console.WriteLine($"Trạng thái kho: {status} ({statusText})");
            Console.WriteLine($"Dự kiến nhập hàng: {restockDisplay}");

        }
        static void BAI_11()
        {
            Console.WriteLine("Bài 11:Tính Lãi Suất Tiết Kiệm Ngân Hàng & Dự Toán Tích Lũy");
            Console.Write("Số tiền gửi (VNĐ):");
            // Kiểm tra tính hợp lệ bằng lệnh if
            if(!decimal.TryParse(Console.ReadLine(),out decimal P) || P<0m)
            {
                Console.WriteLine("\n[LỖI] Số tiền gửi không hợp lệ.");
                return;
            }
            Console.Write("Lãi suất năm (%/năm):");
            if (!double.TryParse(Console.ReadLine(), out double r) || r < 0)
            {
                Console.WriteLine("\n[LỖI] Lãi suất không hợp lệ.");
                return;
            }
            Console.Write("Thời gian gửi (tháng):");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.Write("\n [LỖI] Số tháng gửi không hợp lệ");
                return;
            }
            //Tính lãi đơn
            decimal simpleIn = P * ((decimal)r / 100m) * ((decimal)n / 12m);
            double baseRate = (r / 100.0) / 12.0;
            double totalIndouble = (double)P * Math.Pow(1+ baseRate, n);
            decimal totalamountIn = (decimal)totalIndouble;
            decimal compoundInterest = totalamountIn - P;
            //Tính chênh lệch
            decimal diff = compoundInterest - simpleIn;
            //Hiển thị kết quả
            Console.WriteLine($"Tổng tiền lãi (Lãi đơn):{simpleIn:N0}VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép):{compoundInterest:N0}VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch:{diff:N0}VNĐ (Lãi kép tối ưu hơn)");


        }

        public static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = CultureInfo.InvariantCulture;
            BAI_11();
        }
    }
}
