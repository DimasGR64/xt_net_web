using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    public static class Watching
    {
        public static void Watch()
        {
            string[] args = Environment.GetCommandLineArgs();
            
                using (FileSystemWatcher watcher = new FileSystemWatcher(Welcome.ControlFolder, "*.txt"))
                {
                    watcher.NotifyFilter = NotifyFilters.FileName
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.LastAccess
                                         | NotifyFilters.DirectoryName;

                    watcher.Changed += OnChanged;
                    watcher.Created += OnChanged;
                    watcher.Deleted += OnChanged;
                    watcher.Renamed += OnChanged;

                    watcher.EnableRaisingEvents = true;
                    watcher.IncludeSubdirectories = true;
                }
        }
        private static void OnChanged(object sourse, FileSystemEventArgs f)
        {
            if (f.ChangeType == WatcherChangeTypes.Created)
            {
                Console.WriteLine($"File: {f.FullPath} {f.ChangeType}");
            }
        }
        private static void OnRenamed(object sourse, RenamedEventArgs f)
        {
            if (f.ChangeType == WatcherChangeTypes.Created)
            {
                Console.WriteLine($"File: {f.OldFullPath} {f.FullPath}");
            }
        }

    }
}
