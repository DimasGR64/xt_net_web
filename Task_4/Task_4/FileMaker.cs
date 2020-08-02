using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    public static class FileMaker
    {
        public static void Recovery(string ControlFolder)
        {
            string folder = ControlFolder.Substring(0, ControlFolder.Length);
            folder = folder.Substring(folder.LastIndexOf('\\') + 1);
            string recoveryFolder = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, Welcome.TemplFolder);
            foreach (var item in Directory.GetDirectories(recoveryFolder))
            {
                if (item.Substring(item.LastIndexOf('\\') + 1) == folder)
                {
                    Console.WriteLine("please, input time of recovery");
                    string TimeOfRcovry = Console.ReadLine();
                    string pathToRecover = Path.Combine(Path.Combine(recoveryFolder, $@"{folder}\"), TimeOfRcovry);
                    DirectoryInfo Fold = new DirectoryInfo(ControlFolder);
                    Fold.Delete(true);
                    CopyFolder(pathToRecover, ControlFolder);
                }
            }
        }
        private static void CopyFolder(string FolderForCopy, string ControlFolder)
        {
            DirectoryInfo directory = new DirectoryInfo(FolderForCopy);
            if (!Directory.Exists(ControlFolder))
            {
                Directory.CreateDirectory(ControlFolder);
            }
            var files = directory.GetFiles();
            foreach (var file in files)
            {
                string tmpFolder = Path.Combine(ControlFolder, file.Name);
                file.CopyTo(tmpFolder, false);
            }
        }
    }
}
