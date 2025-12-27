// 🧠 Connection to SOLID:
//  - O: Open/Closed — class should be open for extension, closed for modification
//  - D: Dependency Inversion — App does NOT depend on a concrete logger

using System;

namespace Ex_SOLID_Logger
{
    interface ILogger
    {
        void Log(string msg);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string msg) => Console.WriteLine("[Console] " + msg);
    }

    // New logger type added WITHOUT modifying App ⇒ OCP (Open/Closed principle)
    class FileLogger : ILogger
    {
        public void Log(string msg) => Console.WriteLine("[File] (writing to file) " + msg);
    }

    class App
    {
        private readonly ILogger _logger;  // abstraction

        // Constructor Injection
        public App(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.Log("Application started...");
        }
    }

    class Program
    {
        static void Main()
        {
            App app = new App(new ConsoleLogger()); // we can swap to FileLogger anytime
            app.Run();
        }
    }
}

/*
🔑 WHY INTERFACE HERE?
- If App depended directly on ConsoleLogger, we'd BREAK SOLID.
- With ILogger, we can extend system features WITHOUT modifying App class.

This interface design is what eventually leads to DESIGN PATTERNS like:
  • Strategy
  • Dependency Injection Container
  • Factory Pattern
*/
