using UnityEngine;

public class Properties : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player myPlayer = new Player();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }

    public class Player
    {
        //Member variables can be referred to as
        //fields.
        private int experience;

        //Experience is a basic property
        public int Experience
        {
            get
            {
                //Some other code
                return experience;
            }
            set
            {
                //Some other code
                experience = value;
            }
        }

        //Level is a property that converts experience
        //points into the leve of a player automatically
        public int Level
        {
            get
            {
                return experience / 1000;
            }
            set
            {
                experience = value * 1000;
            }
        }

        //This is an example of an auto-implemented
        //property
        public int Health { get; set; }
    }
}
