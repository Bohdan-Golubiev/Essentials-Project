using UnityEngine;

namespace MemberHiding
{
    public class MemberHiding : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Humanoid human = new Humanoid();
            Humanoid enemy = new Enemy();
            Humanoid orc = new Orc();

            //Notice how each Humanoid variable contains
            //a reference to a different class in the
            //inheritance hierarchy, yet each of them
            //calls the Humanoid Yell() method.
            human.Yell();
            enemy.Yell();
            orc.Yell();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    public class Orc : Enemy
    {
        //This hides the Enemy version.
        new public void Yell()
        {
            Debug.Log("Orc version of the Yell() method");
        }
    }
    public class Enemy : Humanoid
    {
        //This hides the Humanoid version.
        new public void Yell()
        {
            Debug.Log("Enemy version of the Yell() method");
        }
    }
    public class Humanoid
    {
        //Base version of the Yell method
        public void Yell()
        {
            Debug.Log("Humanoid version of the Yell() method");
        }
    }
}
