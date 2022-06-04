using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class HW_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список всех процессов: ");
            var processList = Process.GetProcesses();
            foreach (var process in processList)
            {
                Console.WriteLine($"{process.Id} {process.ProcessName}");
            }
            Console.Write("Название процесса: ");
            var killName = Console.ReadLine();
            try
            {
                processList.First(p => p.ProcessName.ToLower() == killName.ToLower()).Kill();
                Console.WriteLine($"{killName} завершен!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Процесс {killName} не найден!");
            }
            Console.ReadKey(true);
        }
    }
}