using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Highscore : MonoBehaviour
{
    public Text highscoreText;
    private float highscore;
    // Start is called before the first frame update
    void Start()
    {
        string keyName = SceneManager.GetActiveScene().name + "Highscore";
        Debug.Log("Key Name: " + keyName);
        highscore = PlayerPrefs.GetFloat(keyName, 0f);
        Debug.Log("Returned highscore is: " + highscore.ToString());
        UpdateHighscoreText();
    }



    void UpdateHighscoreText(){
        highscoreText.text = highscore.ToString("0");
    }
}
