using System;

namespace Lab2_Task1
{
    
    class Program
    {
        
        static void ShowSeason(int month)
        {
            // Оператор switch здійснює вибір гілки виконання залежно від значення змінної month
            switch (month)
            {
                
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("\nПора року: Зима");
                    break; 

                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("\nПора року: Весна");
                    break;

              
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("\nПора року: Літо");
                    break;

                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("\nПора року: Осінь");
                    break;

                // Блок default виконується, якщо значення не збіглося із жодним case (поза діапазоном 1..12)
                default:
                    Console.WriteLine("\nПомилка! Номер місяця повинен бути цілим числом у діапазоні від 1 до 12.");
                    break;
            }
        }

       
        static void Main(string[] args)
        {
            // Встановлення кодування UTF-8 для коректного відображення української мови в консолі
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Нескінченний цикл для повторного введення даних до бажання користувача вийти
            while (true)
            {
               
                Console.Write("Введіть порядковий номер місяця (1-12) або 0 для виходу: ");

                // Зчитування рядка з консолі
                string input = Console.ReadLine();

                // Спроба перетворення рядка на ціле число
                if (!int.TryParse(input, out int month))
                {
                    Console.WriteLine("\nНекоректне введення! Будь ласка, введіть ціле число.");
                    continue; // Повернення на початок циклу
                }

                // Умова виходу з програми: якщо користувач ввів 0
                if (month == 0)
                {
                    Console.WriteLine("\nДякуємо за використання програми. Завершення роботи...");
                    break; // Переривання циклу while
                }

                // Виклик методу для визначення пори року
                ShowSeason(month);
            }
        }
    }
}
