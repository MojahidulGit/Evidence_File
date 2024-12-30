namespace GenericApproach
{
    public interface ITypeSpecificBehavior<T>
    {
        string GetTypeSpecificBehavior<T>(T data) where T : Animal;
    }
}
