using UnityEngine;

public class Statics : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static int playerCount = 0;
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();
        int x = Enemy.enemyCount;
        int y = Utilities.Add(5, 6);
        Debug.Log(x + " " + y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Enemy
{
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
}
public static class Utilities
{
    //A static method can be invoked without an object
    //of a class. Note that static methods cannot access
    //non-static member variables.
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
