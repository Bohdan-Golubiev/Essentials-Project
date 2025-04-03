using UnityEngine;

public class Inheritance : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Apple : Fruit
{
    public Apple()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    public Apple(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}
public class Fruit
{
    public string color;
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}

