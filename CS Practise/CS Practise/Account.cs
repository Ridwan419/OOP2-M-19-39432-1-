using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practise
{
class Account
    {
        string accName, accId;
        int balance;
        public Account(string accName, string accId, int balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
            
            if(balance>0)
            {
                this.balance = balance;
                Console.WriteLine("Current Balance " + balance);
            }
                 

        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.balance = balance + amount;
                Console.WriteLine("Current balance after deposit: " + this.balance);

            }

        }
       
        public void Withdraw(int amount)
        {
            if(amount<balance){
		   this.balance= this.balance-amount;
               Console.WriteLine("Current balance after withdrawal: "+this.balance);
	   }
	   else{ 
		   Console.WriteLine("amount of withdrawal must be lesser than current balance");
	   }
   }
        }

}
