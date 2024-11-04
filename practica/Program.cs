using System;

namespace practica
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine(" здравствуйте!!!!!!! почему то не работает");

            //// работа дочернего класса. Вводим Имя пользователя и Адрес.
            //// Выводится информация о пользователе. Период берется с 01.01.2024 до сегодняшнего дня
            //// Если Сегодняшняя дата позднее, чем дата, с которой начинается просрочка, то выводится сумма задолжности
            //// Дату просрочки можно менять только в дочернем классе. в настоящее время дата просрочки начинается с 15.02.2024



            //// Ввод только Имени и адреса с консоли
            //OverdueInvoice inс1 = new OverdueInvoice();
            
            ////Попытка преобразования выражения к определенному типу
            //Object objectInvoice = new OverdueInvoice();
            //Invoice invoice = objectInvoice as Invoice;
            //if (invoice != null)
            //{
            //    Console.WriteLine("good");
            //}
            //else
            //{
            //    Console.WriteLine("no good");
            //}
          
            


            //// Преобразование базового класса к типу дочернего
            //OverdueInvoice overdueInvoice = new OverdueInvoice();
            //Invoice o_i = overdueInvoice;
            //Console.WriteLine(o_i.GetType()); // OverdueInvoice
            
            //Invoice inc4 = new OverdueInvoice();
            //Console.WriteLine(inc4.GetType()); // OverdueInvoice
            

            //// Проверка Методов
            //DateTime dateTime = DateTime.Today;
            //OverdueInvoice myInv = new OverdueInvoice("Никита", "Чкалова 7", dateTime, 5000, "0987654321");
            //Invoice i = (Invoice)myInv;
            //i.GetInvoiceInf("Никита", "Чкалова 7", dateTime, 5000, "1234567890");
            //// методы срабатывают из дочернего класса. не получается привести тип дочернего к родительскому
           

        }
    }
}
