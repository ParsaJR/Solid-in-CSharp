using System.Runtime.InteropServices.ComTypes;
namespace Single_Responsibility_Principle
{
    public class FileLogger
    {
        public static void Log(string content){
            System.IO.File.WriteAllText("/home/parsajr",content);
        }
    }
}