using Encapsulation.AssemblyA;

namespace Encapsulation.AssemblyB;

public class ClassB
{
    private readonly ClassA _a;

    public ClassB()
    {
        _a = new ClassA();
    }
}
