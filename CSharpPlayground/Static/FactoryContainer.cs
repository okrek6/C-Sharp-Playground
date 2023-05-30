namespace CSharpPlayground.Static
{
    public static class FactoryContainer
	{
        object subject;
        public static void Register<T>(object input)
        {
            subject = input;
        }
        public static object CreateOrResolve<T>()
        {
            if (subject = null)
            {
                return subject = new object();
            }
            return subject;
        }
    }
}