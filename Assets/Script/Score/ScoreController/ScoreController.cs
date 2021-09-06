using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private static ScoreController _instance = null;

    public static ScoreController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreController>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: ScoreManager not Found");
                }
            }

            return _instance;
        }
    }
    private static int highScore;
    public int tileRatio;
    public int comboRatio;

    public int HighScore { get { return highScore; } }
    public int CurrentScore { get { return currentScore; } }

    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        ResetCurrentScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public void IncrementCurrentScore(int tileCount, int comboCount)
    {
        currentScore += (tileCount * tileRatio) * (comboCount * comboRatio);
        AudioController.Instance.PlayScore(comboCount > 1);
    }

    public void SetHighScore()
    {
        highScore = currentScore;
    }

}
