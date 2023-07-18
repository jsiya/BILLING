namespace BILLING.Models;

public class Entity
{
    protected static int nextId = 1;
    protected static int GenerateId()
    {
        return nextId++;
    }
}
