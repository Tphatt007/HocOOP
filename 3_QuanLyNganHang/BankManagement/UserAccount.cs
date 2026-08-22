using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class UserAccount
    {

        // Private backing fields
        private string password;
        private decimal balance;

        // 1. AccountId - Init-Only Property
        public string AccountId { get; set; }

        // 2. Username - Auto-Implemented Property
        public string Username { get; set; }

        // 3. Password - Write-Only Property
        public string Password
        {
            set
            {
                password = "[ENCRYPTED]_" + value;
            }
        }

        // 4. Balance - Full Property with Validation
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Balance cannot be negative!");
                }
                else
                {
                    balance = value;
                }
            }
        }

        // 5. IsVIP - Computed Read-Only Property
        public bool IsVIP => Balance >= 10000m;

        // 6. CreatedDate - Get-Only Auto Property
        public DateTime CreatedDate { get; }

        // Constructor
        public UserAccount()
        {
            CreatedDate = DateTime.Now;
        }

    }
}
