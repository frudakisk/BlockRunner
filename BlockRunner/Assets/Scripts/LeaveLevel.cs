using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveLevel : MonoBehaviour
{
    public void QuitLevel(){
        SceneManager.LoadScene(1);
        NumberOfCollisions.scoreValue = 0;
        //trackTime.LevelQuit();
        TimerManager.Instance.ResetTimer();
    }

 

}
