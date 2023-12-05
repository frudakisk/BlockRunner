using UnityEngine;
using UnityEngine.UI;

public class NumberOfCollisions : MonoBehaviour
{
    public Text collisionText; //referencing the actual text in the game - must hook up 
    public static int scoreValue = 0; //the value of the score which is the number of collisions we keep track of whole game
    void Start(){
        collisionText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        collisionText = GetComponent<Text>();
        collisionText.text = "Number of Collisions: " + scoreValue.ToString();
    }

    public int GetScoreValue(){
        return scoreValue;
    }
}
