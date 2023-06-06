namespace AspNetCoreCourse.Services
{
    public class TextLog:ILog
    {
        public void Log()
        {
            Console.WriteLine("Bu bir TextLog'dur");
        }
    }
}
