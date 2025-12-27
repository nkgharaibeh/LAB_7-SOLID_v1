// 🧠 WHY THIS DESIGN?
// Before: BankAccount derived from only one class — inheritance alone caused rigidity.
// Now: We expose account BEHAVIOR through an interface => “Programming to abstraction”.
// This is the foundation of SOLID ⇒ (D) Dependency Inversion Principle.

using System;

namespace Ex_Interface_SOLID
{
    interface IAccount
    {
        string HolderName { get; }
        double Balance { get; }

        double CalculateInterest();
    }

    abstract class BaseAccount : IAccount
    {
        public string HolderName { get; protected set; }
        public double Balance { get; protected set; }

        protected BaseAccount(string holderName, double balance)
        {
            HolderName = holderName;
            Balance = balance;
        }

        // Abstract ⇒ subclasses MUST define behavior
        public abstract double CalculateInterest();
    }

    class SavingsAccount : BaseAccount
    {
        public SavingsAccount(string holderName, double balance) : base(holderName, balance) { }
        public override double CalculateInterest() => Balance * 0.05;
    }

    class StudentAccount : BaseAccount
    {
        public StudentAccount(string holderName, double balance) : base(holderName, balance) { }
        public override double CalculateInterest() => Balance * 0.01;
    }

    class Program
    {
        static void Main()
        {
            // KEY: Interface reference — not concrete class → 🔑 D in SOLID
            IAccount acc = new SavingsAccount("Mona", 1000);

            Console.WriteLine($"{acc.HolderName} interest = {acc.CalculateInterest()}");
            Console.ReadKey();
        }
    }
}

/*
🧩 SOLID Note:
- (D) Dependency Inversion: High-level modules depend on abstractions, NOT concrete classes.
- Because IAccount exists, we can add "TeacherAccount" without changing existing code.

WITHOUT INTERFACE:
    SavingsAccount acc = new SavingsAccount(...);
WITH INTERFACE:
    IAccount acc = new SavingsAccount(...);  // better, more flexible
*/
