using System;

namespace CarApplication
{
    // описание класса Car
    public class Car
    {
        // открытые поля для хранения данных
        public string Brand;       // марка
        public string LicensePlate;  // гос номер
        public int Mileage;         // пробег

        // метод Show() для вывода данных об автомобиле
        public void Show()
        {
            Console.WriteLine("Данные об автомобиле");
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Гос. номер: {LicensePlate}");
            Console.WriteLine($"Пробег: {Mileage} км");
            Console.WriteLine();
        }

        // метод для расчета среднегодового пробега
        public double CalculateAverageYearlyMileage(int ageInYears)
        {
            if (ageInYears <= 0)
            {
                // возвращаем 0, если возраст некорректен, чтобы избежать деления на ноль
                return 0;
            }
            return (double)Mileage / ageInYears;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // создание объекта класса Car
            Car myCar = new Car();

            // задание значений свойствам объекта
            myCar.Brand = "Жигули";
            myCar.LicensePlate = "Т144ТО";
            myCar.Mileage = 10350;

            // вывод на экран значений свойств с помощью метода Show()
            myCar.Show();

            // расчет и вывод среднегодового пробега для автомобиля возрастом 2 года
            int carAge = 2;
            double averageMileage = myCar.CalculateAverageYearlyMileage(carAge);

            Console.WriteLine($"Среднегодовой пробег для автомобиля возрастом {carAge} года составляет: {averageMileage:F2} км/год.");
            Console.ReadKey();
        }
    }
}
