using System;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    private void Start()
    {
        Mammal[] mammals = new Mammal[2];
        mammals[0] = new Cat();
        mammals[1] = new Dog();
        if (mammals[0] is Cat)
        {
            Cat cat = mammals[0] as Cat;
            cat.Meow();
        }
        if (mammals[1] is Dog)
        {
            Dog dog = (Dog)mammals[1];
            dog.Woof();
        }
    }
}
public class Animal
{ }
public class Mammal : Animal
{
    public void GrowFur()
    { }
}
[Serializable]
public class Cat : Mammal
{
    public void Meow()
    {
        Debug.Log("Meaw");
    }
}
[Serializable]
public class Dog : Mammal
{
    public void Woof()
    {
        Debug.Log("Woof");
    }
}

