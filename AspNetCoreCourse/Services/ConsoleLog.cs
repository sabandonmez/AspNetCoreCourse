namespace AspNetCoreCourse.Services
{
    public class ConsoleLog:ILog
    {
        public void Log()
        {
            Console.WriteLine("Bu bir ConsoleLog'dur");
        }
    }
}
