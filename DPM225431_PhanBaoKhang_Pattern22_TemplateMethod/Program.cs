using DPM225431_PhanBaoKhang_Pattern22_TemplateMethod;

public class Program
{
    public static void Main(string[] args)
    {
        AbstractClass aA = new ConcreteClassA();
        aA.TemplateMethod();
        AbstractClass aB = new ConcreteClassB();
        aB.TemplateMethod();
        // Wait for user
        Console.ReadKey();
    }
}