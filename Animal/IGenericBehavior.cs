namespace GenericApproach
{

    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior(T obj);
    }
}
