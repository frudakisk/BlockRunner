using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance { get; private set; }
    public float Timer { get; private set; }
    public bool IsTiming { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            StartTimer();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartTimer()
    {
        Timer = 0f;
        IsTiming = true;
    }

    public void StopTimer()
    {
        IsTiming = false;
    }

    public void UpdateTimer()
    {
        if (IsTiming)
        {
            Timer += Time.deltaTime;
        }
    }

    public void ResetTimer()
    {
        Timer = 0f;
        IsTiming = false;
        Destroy(gameObject);
    }
}
