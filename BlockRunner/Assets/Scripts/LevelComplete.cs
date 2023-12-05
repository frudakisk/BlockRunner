using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //use build index instead of name to go to next level... Unity -> Files -> Build Settings
        SceneManager.LoadScene(1);
        TimerManager.Instance.ResetTimer();
    }


}
