using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // мені здалося, що сам Reporter повинен відображувати те, що відбувається зі складом (додавання\видалення\редагування продуктів)
    // тож я вирішив зробити його перекладачем, що буде казати користувачу його дії або записувати їх у файл
    // інтерфейс IReporter демонструє принцип dependency inversion, бо він використовується в класі 
    // WarehouseManager, що у свою чергу залежить від цієї абстрації
    public interface IReporter
    {     
        void Report(string message);
    }
    //надсилання репортів у консоль
    public class ConsoleReporter : IReporter
    {
        public void Report(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    // записування репортів у файл
    public class FileReporter : IReporter
    {
        public void Report(string message)
        { 

            string filePath = @"Report.txt";

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"[{DateTime.UtcNow.ToString()}] {message}");
            }
        }
    }
}
