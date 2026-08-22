using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- BỘ KIỂM TRA (TEST HARNESS) ---

            // 1. Kiểm tra khởi tạo đối tượng & Thuộc tính Init-Only
            UserAccount user = new UserAccount
            {
                AccountId = "ACC-99201",
                Username = "Alice_Code",
                Password = "SuperSecretPassword123"
            };

            // Cố gắng sửa đổi AccountId sau khi tạo sẽ gây lỗi biên dịch!
            // user.AccountId = "ACC-00000"; // BỎ CHÚ THÍCH (COMMENT) ĐỂ XEM LỖI BIÊN DỊCH

            Console.WriteLine($"Account ID: {user.AccountId}");
            Console.WriteLine($"Username: {user.Username}");
            Console.WriteLine($"Account Created: {user.CreatedDate}");

            // 2. Kiểm tra thuộc tính chỉ ghi (Write-Only)
            // Cố gắng đọc Password sẽ gây lỗi biên dịch!
            // Console.WriteLine(user.Password); // BỎ CHÚ THÍCH ĐỂ XEM LỖI BIÊN DỊCH

            // 3. Kiểm tra Validation của Full Property
            Console.WriteLine("\n--- Testing Balance Updates ---");
            user.Balance = 5000m;
            Console.WriteLine($"Current Balance: {user.Balance:C}");

            user.Balance = -200m; // Phải hiển thị cảnh báo và bỏ qua việc cập nhật
            Console.WriteLine($"Current Balance after invalid attempt: {user.Balance:C}");

            // 4. Kiểm tra thuộc tính chỉ đọc được tính toán (IsVIP)
            Console.WriteLine($"\nIs VIP? {user.IsVIP}"); // Phải là false ($5000 < $10000)

            user.Balance = 15000m;
            Console.WriteLine($"Updated Balance: {user.Balance:C}");
            Console.WriteLine($"Is VIP now? {user.IsVIP}"); // Phải là true ($15000 >= $10000)
        }
    }
}
