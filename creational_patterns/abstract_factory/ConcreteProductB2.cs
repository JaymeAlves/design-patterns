public class ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "UsefulFunctionB";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"The result of the B2 collaborating with the ({result})";
    }
}