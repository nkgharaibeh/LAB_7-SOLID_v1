# LAB_7-SOLID_v1

# Lab 5 → Lab 6 → Lab 7 — The Bigger Picture of OOP Design

## 📌 Why this journey matters
We began with writing simple classes…  
Then we learned *Inheritance* → to reuse code  
Then *Polymorphism* → to change behavior dynamically  
Then *Abstract Classes* → to enforce a partial contract  
And now *Interfaces* → the highest level of abstraction and flexibility

🧠 In a professional system, INTERFACES are NOT syntax…  
They are the **spine** that enables:
- modularity
- evolvability
- testing
- and ultimately → scalable architectures

---

## 🪜 The Evolution of Thought

| Stage | Concept Learned | Weakness That Appears | Why We Needed the Next Stage |
|-------|-----------------|------------------------|------------------------------|
| 1️⃣ Classes & Objects | Data + behavior | Code duplication | Inheritance |
| 2️⃣ Inheritance | Share fields & methods | Too rigid, deep hierarchy | Polymorphism |
| 3️⃣ Polymorphism (virtual/override) | Change behavior at runtime | Still tied to single inheritance | Abstract classes |
| 4️⃣ Abstract Classes | Enforce rule + provide partial implementation | Only ONE class parent allowed | Interfaces |
| 5️⃣ Interfaces | Pure contract, multiple inheritance of behavior | Too abstract? Still needs discipline | SOLID Principles |
| 6️⃣ SOLID | Rules for writing maintainable systems | Need reusable architecture | Design Patterns |
| 7️⃣ Design Patterns | Reusable templates for solving problems | → Leads toward architecture thinking | Final stage |

---

## 🎯 What Interfaces Fix
Interfaces solve two major engineering pains:

| Problem | Example | Interface Solution |
|---------|---------|--------------------|
| Class depends directly on another class (tight coupling) | `App → ConsoleLogger` | Use `ILogger` abstraction |
| System must support MANY implementations | `SavingsAccount`, `TeacherAccount`, `StudentAccount`, etc. | All implement `IAccount` |

---

## 🔥 Enter SOLID (Only where needed)

We only introduce SOLID here because **INTERFACES are the door to SOLID.**

### (D) Dependency Inversion Principle
> High-level modules should not depend on low-level modules.  
> Both should depend on abstractions.

Example:

```csharp
App app = new App(new ConsoleLogger());
