using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void GoToCreditsScene() {
        Debug.Log("GOING TO CREDITS SCREEN");
        SceneManager.LoadScene("Credits");
        //Application.Quit();
    }

    public void Quit(){
        Debug.Log("QUIT");
        Application.Quit();
    }
}
