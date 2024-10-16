namespace Encapsulation.AssemblyA;

public class ClassA
{
    internal ClassAInternal AInternal;

    public ClassA()
    {
        AInternal = new ClassAInternal();
    }
}

internal class ClassAInternal
{

}
