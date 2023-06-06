using AspNetCoreCourse.Services;

namespace AspNetCoreCourse
{
    public class Example
    {
        //Bu yapılanmayı normalde bu şekilde kullanmıyoruz biz nasıl çalıştığını anlamak için yaptık bu sınıfı . Normalde Program.cs de services 
        // builder.Services propu üzerinden erişiyoruz.
        public Example()
        {
            IServiceCollection services = new ServiceCollection(); // built - in IoC
            services.Add(new ServiceDescriptor(typeof(ConsoleLog),new ConsoleLog()));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));
            
            ServiceProvider provider = services.BuildServiceProvider();
            provider.GetService<ConsoleLog>();
            provider.GetService<TextLog>();

        }
    }
}
