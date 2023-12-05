using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Transform player;
    public Text finalScore;
    void OnTriggerEnter() {
        gameManager.CompleteLevel();
        TimerManager.Instance.StopTimer();
        float score = CalculatePlayerScore();
        CreateScore(score);
        //HighscoreManager.instance.SetHighscore(score);
        FindObjectOfType<HighscoreManager>().SetHighscore(score);
        
    }

    void CreateScore(float score){
        finalScore.text = score.ToString("0");
    }

    public float CalculatePlayerScore(){
        float distance = player.position.z;
        float time = TimerManager.Instance.Timer;
        int collisions = NumberOfCollisions.scoreValue;
        float score = distance * 100 / (time + collisions);
        return score;
    }
}
