public class ConcreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "UsefulFunctionB";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"The result of the B1 collaborating with the ({result})";
    }
}