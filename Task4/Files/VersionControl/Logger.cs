using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Files
{
    class Logger
    {
        FileSystemWatcher watcher;
        bool enabled = true;
        private string _filesDirectory;
        private string _logDirectory;

        public Logger(string FilesDirectory, string LogDirectory)
        {
            _filesDirectory = FilesDirectory;
            _logDirectory = LogDirectory;
        }

        public void Start()
        {
            using (watcher = new FileSystemWatcher(_filesDirectory, "*.txt"))
            {
                watcher.NotifyFilter = NotifyFilters.LastAccess
                    | NotifyFilters.LastWrite
                    | NotifyFilters.DirectoryName
                    | NotifyFilters.FileName
                    | NotifyFilters.CreationTime;
                watcher.IncludeSubdirectories = true;
                watcher.Deleted += OnChanged;
                watcher.Created += OnChanged;
                watcher.Changed += OnChanged;
                watcher.Renamed += OnChanged;
                watcher.EnableRaisingEvents = true;
                while (enabled)
                    Thread.Sleep(1000);
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            var date = DateTime.Now;
            var newDir = _logDirectory + PrintDate(date);
            Console.WriteLine(newDir);
            Restorer.DirectoryCopy(_filesDirectory, newDir, true);
        }

        public static string PrintDate(DateTime date)
        {
            var res = "\\" + date.Day + "." + date.Month + "." + date.Year + "_"
                + date.Hour + "h" + date.Minute + "m" + date.Second + "s";
            return res;
        }
    }
}