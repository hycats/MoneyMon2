using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMon2
{
    class Model
    {
        public enum AccountType {
            Cash = -1,
            Bank = 0,
            Credit = 1
        };

        private DataSet1 ds_ = null;

        private bool isFakeData_ = true;

        public void ConfigModule(DataSet1 ds)
        {
            ds_ = ds;
        }

        public void MakeAccount(string name, AccountType type, int initial_money)
        {
            ds_.dtblAccounts1.AdddtblAccounts1Row(name, Type: (int)type, InitialMoney: initial_money, Id: ds_.dtblAccounts1.Count);
        }

        public void MakePresets()
        {
            ds_.dtblAccounts1.Clear();
            MakeAccount("現金", AccountType.Cash, 0);

            ds_.dtblExpense1.Clear();

        }

        public void InitModule()
        {
            MakePresets();

            if (isFakeData_)
            {
                MakeAccount("SBI証券", AccountType.Bank, 0 );
                MakeAccount("KAMPO", AccountType.Credit, 0 );
            }
        }
    }
}
