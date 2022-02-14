using System.Diagnostics;

namespace Project_Management_System.DependencyInjection
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void Write()
        {
            Debug.WriteLine("Testing Dependency Injection");

        }
    }
}
