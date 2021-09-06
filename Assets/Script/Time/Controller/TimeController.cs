using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    private static TimeController _instance = null;

    public static TimeController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<TimeController>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: TimeManager not Found");
                }
            }

            return _instance;
        }
    }

    public int duration;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.Instance.IsGameOver)
        {
            return;
        }

        if (time > duration)
        {
            SceneManager.Instance.GameOver();
            return;
        }

        time += Time.deltaTime;
    }

    public float GetRemainingTime()
    {
        return duration - time;
    }

}
