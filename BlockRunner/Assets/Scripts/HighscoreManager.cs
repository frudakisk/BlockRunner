using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighscoreManager : MonoBehaviour
{
    public static HighscoreManager instance;

    private float highscore = 0f;

    public Text highscoreText;
    string globalKeyName;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Load highscore from PlayerPrefs
        string keyName = SceneManager.GetActiveScene().name + "Highscore";
        globalKeyName = keyName;
        highscore = PlayerPrefs.GetFloat(keyName, 0f);
    }

    public void SetHighscore(float newHighscore)
    {
        
        
        //reset the keyname and set highscore to that
        string keyName = SceneManager.GetActiveScene().name + "Highscore";
        globalKeyName = keyName;
        highscore = PlayerPrefs.GetFloat(globalKeyName, 0f);
        Debug.Log("Current highscore: "+ highscore);
        Debug.Log("current score: " + newHighscore);
        Debug.Log("Global Key Name: " + globalKeyName);
        if (newHighscore > highscore)
        {
            Debug.Log("Highscore before setting: " + PlayerPrefs.GetFloat(globalKeyName, 0f));
            highscore = newHighscore;
            PlayerPrefs.SetFloat(globalKeyName, highscore);
            Debug.Log("Highscore AFTER setting: " + PlayerPrefs.GetFloat(globalKeyName, 0f));
            PlayerPrefs.Save();
            UpdateHighscoreText();
        }
    }

    public float GetHighscore()
    {
        return highscore;
    }

    void UpdateHighscoreText(){
        highscoreText.text = highscore.ToString("0");
    }
}
