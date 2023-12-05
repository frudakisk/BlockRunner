using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text highscoreText;
    public void CreateScore(float score){
        //(scoreText * 100) / (Timer + scoreValue)
        highscoreText.text = score.ToString();
    }

    //need a function to put this high score on the main menu page
}
