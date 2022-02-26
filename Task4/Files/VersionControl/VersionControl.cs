using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class VersionControl
    {
        public static void Start()
        {
            Console.WriteLine("Input path to directory with files");
            var pathF = CheckPath();
            Console.WriteLine("Input path to directory in which you whant to save logs");
            var pathL = CheckPath();
            while (true)
            {
                Console.WriteLine("Choose the number of the option\n" +
                    "1. Observe\n" +
                    "2. Restore\n" +
                    "3. Exit");
                if (!int.TryParse(Console.ReadLine(), out int choose))
                {
                    Console.WriteLine("Error. Try again.");
                    continue;
                }
                if (choose < 1 || choose > 3)
                {
                    Console.WriteLine("Error. Try again.");
                    continue;
                }
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Watcher working right now!");
                        var watcher = new Logger(pathF, pathL);
                        watcher.Start();
                        break;
                    case 2:
                        Console.WriteLine("Start the restorer.");
                        var restorer = new Restorer(pathF, pathL);
                        restorer.Start();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Error. Try again.");
                        break;
                }
            }
        }

        public static string CheckPath()
        {
            while (true)
            {
                var path = Console.ReadLine();
                if (Directory.Exists(path))
                    return path;
                Console.WriteLine("Error, this directory does not exist. Try again.");
            }
        }
    }
}
