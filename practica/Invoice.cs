using System;




namespace practica
{
    class Invoice
    {
        public static string clientName = "Неизвестно";
        public static string adres = "Неизвестно";
        public static DateTime period;
        public static int summ = 0;
        public static string codeOfInvoice = "";
        static int Counter;
        static int Total;


        public void Chet()
        {
            Random random = new Random();
            codeOfInvoice = Convert.ToString(random.Next(100000000, 999999999)) + Convert.ToString(random.Next(0, 9));
        }
        
        
        public Invoice() // конструктор 1
        {
            Console.ReadLine();
            Console.Clear();
            DateTime dateTime = DateTime.Today;
            Random random = new Random();
            Console.WriteLine("Получатель: ");
            clientName = Console.ReadLine();
            Console.WriteLine("Адрес получателя: ");
            adres = Console.ReadLine();
            period = dateTime;
            summ = random.Next(0, 10000);
            Chet();
            GetInvoiceInf(clientName, adres, period, summ, codeOfInvoice);

        }
        public Invoice(string name, string adres, DateTime period) // конструктор 2
        {
            Random random = new Random();
            clientName = name;
            adres = adres;
            period = period;
            summ = random.Next(0, 10000);
            Chet();
            GetInvoiceInf(clientName, adres, period, summ, codeOfInvoice);
        }
        public Invoice(string chet) // конструктор 3
        {
            string open = "7777777777";
            if (chet == open)
            {
                DateTime dateTime = DateTime.Today;
                Random random = new Random();
                clientName = "Никита";
                adres = "Оренбург, Чкалова 7";
                summ = random.Next(0, 10000);
                codeOfInvoice = chet;
                period = dateTime;
                GetInvoiceInf(clientName, adres, period, summ, codeOfInvoice);

            }
            else
            {
                Console.WriteLine("=================");
                Console.WriteLine($"Не удалось найти клиента с расчетным счетом {chet}");
                Console.WriteLine("=================");
            }

        }
        public Invoice(string clientName, string adres, DateTime period, int summ, string codeOfInvoice) 
        { 
            GetInvoiceInf(clientName, adres, period,  summ, codeOfInvoice); 
        }
        public virtual void GetInvoiceInf(string clientName, string adres, DateTime period, int summ, string codeOfInvoice)
        {
            if (Check(clientName, adres) && (CheckSumm(summ)) && (CheckChet(codeOfInvoice)))
            {
                
                Console.WriteLine("===============");
                Console.WriteLine($"Описание" +
                $"\nПолучатель: {clientName}" +
                $"\nАдрес: {adres}" +
                $"\nРасчетный счет: {codeOfInvoice}" +
                $"\nПериод: 01.01.2024 -- {period}" +
                $"\nСумма: {summ}");
                Console.WriteLine("===============");
                Counter++;
                Console.WriteLine($"Количество объектов => {GetCounter()}");
                Console.WriteLine($"Общая сумма всех счетов => {GetSumm(summ)}");
                Console.WriteLine("===============");
                

            }
        }
        public static int GetCounter() { return Counter; }
        public static int GetSumm(int summ) { return Total = Total + summ; }
        public bool Check(string clientName, string adres)
        {
            if (clientName == "")
            {
                Console.WriteLine("Ошибка!\nВы ввели пустую стрку \"Получатель\"");
                return false;
            }
            else if (adres == "")
            {
                Console.WriteLine("Ошибка!\nВы ввели пустую стрку \"Адрес\"");
                return false;
            }

            return true;
        } 
        public bool CheckSumm(int summ)
        {
            if (summ > 10000) { Console.WriteLine("Сумма должна быть меньше 100000"); return false; }
            else if (summ < 0) { Console.WriteLine("Сумма не должна быть отрицательна"); return false; }
            return true;
        }

        public bool CheckChet(string codeOfInvoice)
        {
            if (codeOfInvoice.Length != 10) { Console.WriteLine("Счет должен быть из 10 цифр"); return false; }
            return true;
        }

    }
}

