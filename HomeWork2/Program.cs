using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    abstract class Worker
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double PayType { get; set; }
        public abstract void CalPay();
    }
    class HourlyPayWorker : Worker
    {
        public HourlyPayWorker(int id, string name, float paytype)
        {
            ID = id;
            Name = name;
            PayType = paytype;
        }
        public override void CalPay()
        {
            Console.WriteLine("ID= " + ID + " Имя рабочего с почасовой оплатой: " + Name + "\n" + "Ежемесячная зарплата= " + 20.8 * 8 * PayType + "\n");
            PayType = 20.8 * 8 * PayType;
        }

    }
    class StaticPayWorker : Worker
    {
        public StaticPayWorker(int id, string name, float paytype)
        {
            ID = id;
            Name = name;
            PayType = paytype;

        }
        public override void CalPay()
        {
            Console.WriteLine("ID= " + ID + " Имя рабочего с фиксированной оплатой: " + Name + "\n" + "Ежемесячная зарплата= " + PayType);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            List<Worker> workers = new List<Worker>();
            workers.Add(new HourlyPayWorker(45, "Александр", 13312));
            workers.Add(new StaticPayWorker(38, "Максим", 13320));
            workers.Add(new HourlyPayWorker(01, "Анатолий", 11350));
            workers.Add(new StaticPayWorker(12, "Владислав", 24324));
            workers.Add(new HourlyPayWorker(46, "Игорь", 11310));
            workers.Add(new HourlyPayWorker(31, "Евгений", 13200));
            workers.Add(new StaticPayWorker(69, "Марина", 16440));
            workers.Add(new StaticPayWorker(61, "Ирина", 21300));
            workers.Add(new StaticPayWorker(82, "Name1", 13200));
            workers.Add(new HourlyPayWorker(88, "Name2", 12418));
            foreach (Worker worker in workers)
                worker.CalPay();
            Console.WriteLine("------------------------");
            Console.WriteLine("Сортировка по возрастанию");
            Console.ReadKey();

        }
    }
}
