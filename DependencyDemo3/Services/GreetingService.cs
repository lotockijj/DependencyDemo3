namespace DependencyDemo3.Services
{
    public class GreetingService :IGreetingService
    {
        public string GetGreeting()
        {
            return "Hello Roman " + GetHashCode() + "  ";
        }
    }
}
