using System.Reflection;

namespace AspNetCoreCourse.Business
{
    public class TypeConversion
    {
        public static TResult Conversion<T,TResult>(T model) where TResult : class ,new()
        {
            TResult result = new TResult();

            typeof(T).GetProperties().ToList().ForEach(p =>
            {
                PropertyInfo tRProp = typeof(TResult).GetProperty(p.Name);
                tRProp.SetValue(result,p.GetValue(model));
            });
            return result;
        }
    }
}
