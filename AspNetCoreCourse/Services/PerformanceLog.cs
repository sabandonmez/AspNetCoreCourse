namespace AspNetCoreCourse.Services
{
    public class PerformanceLog :ILog
    {
        public PerformanceLog(int a)
        {

        }
        public void Log()
        {
            Console.WriteLine("Bu bir PerformanceLog'dur");
        }

    }
}
