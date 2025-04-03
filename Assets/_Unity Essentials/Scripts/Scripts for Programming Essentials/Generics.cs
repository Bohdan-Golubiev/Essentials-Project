using UnityEngine;

public class Generics : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenericMethod<int>(5);

        GenericClass<int> myClass = new GenericClass<int>();

        myClass.UpdateItem(5);
    }
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
