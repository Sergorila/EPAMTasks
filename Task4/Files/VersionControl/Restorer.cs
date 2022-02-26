using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Restorer
    {
        private string _filesDirectory;
        private string _logDirectory;

        public Restorer(string FilesDirectory, string LogDirectory)
        {
            _filesDirectory = FilesDirectory;
            _logDirectory = LogDirectory;
        }

        public void Start()
        {
            Console.WriteLine("Choose the number of the backup.");

            var logdir = new DirectoryInfo(_logDirectory);
            var logs = logdir.GetDirectories();
            ShowDirs(logs);

            string input = Console.ReadLine();
            int choose;
            bool success = int.TryParse(input, out choose);
            if (success)
            {
                if (choose <= logs.Length && choose > 0)
                {
                    var logDirectory = logs[choose-1];
                    if (logDirectory.Exists)
                    {
                        var workDirectory = new DirectoryInfo(_filesDirectory);
                        foreach (var file in workDirectory.GetFiles())
                        {
                            try
                            {
                                file.Delete();
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        foreach (var dir in workDirectory.GetDirectories())
                        {
                            try
                            {
                                dir.Delete(true);
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        DirectoryCopy(logDirectory.ToString(), _filesDirectory, true);
                    }
                    else
                        Console.WriteLine("There is no backup for this time!");
                }
                else
                {
                    Console.WriteLine("Error. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Error. Try again.");
            }

        }

        public static void DirectoryCopy(string filesDir, string newDir, bool copySubDirs)
        {
            var dir = new DirectoryInfo(filesDir);
            var dirs = dir.GetDirectories();

            if (!Directory.Exists(newDir))
            {
                Directory.CreateDirectory(newDir);
            } 
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                var tempPath = Path.Combine(newDir, file.Name);
                try
                {
                    file.CopyTo(tempPath, true);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            if (copySubDirs)
            {
                foreach (var subDir in dirs)
                {
                    var tempPath = Path.Combine(newDir, subDir.Name);
                    DirectoryCopy(subDir.FullName, tempPath, copySubDirs);
                }
            }
        }

        public void ShowDirs(DirectoryInfo[] logs)
        {
            int i = 1;
            foreach (var item in logs)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }
        }
    }
}