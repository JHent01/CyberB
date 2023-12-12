using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_2
{
    internal class Employee
    {
         string name;
         string lastName;
        int taxes;
        int salaryBeforeTaxes;
        int salaryAfterTaxes;
        string position;
        public Employee(string name,string lastName) 
        { 
            this.name = name;
            this.lastName = lastName;

        }
        public void Salary() 
        {
            Console.Write("Введiть номер посади  (1 - Штатний робітник, 2 - Адмін, 3 - Голова компанії) ");
            int sal = int.Parse(Console.ReadLine());
            switch (sal)
            {
                case 1: position= "Штатний робітник"; salaryBeforeTaxes = 3000 ; taxes = 3000 * 20/100 ; salaryAfterTaxes = 3000 - (3000 * 20 / 100); break;
                case 2: position= "Адмін"; salaryBeforeTaxes = 5000; taxes = 5000 * 20 /100 ; salaryAfterTaxes = 5000 - (5000 * 20 / 100); break;
                case 3: position= "Голова компанії"; salaryBeforeTaxes = 10000; taxes = 10000 * 20/100 ; salaryAfterTaxes = 10000 - (10000 * 20 / 100); break;

            }

            Console.WriteLine($" Робітник: {name} {lastName}\n На посаді: {position}\n Отримує до сплати налогів :{salaryBeforeTaxes}\n Після сплати налогів :{salaryAfterTaxes}\n Налог :{taxes} ");
           
        }
    }
}
