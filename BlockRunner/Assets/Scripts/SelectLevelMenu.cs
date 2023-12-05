using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevelMenu : MonoBehaviour
{
    //public Text buttonName;
    void Start() {
        NumberOfCollisions.scoreValue = 0;
    }

    public void StartLevel(GameObject button) {
        SceneManager.LoadScene(button.name);
    }

}