using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [Header("UI")]
    public GameOverView GameOverUI;

    private static SceneManager _instance = null;

    public static SceneManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SceneManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: GameFlowManager not Found");
                }
            }

            return _instance;
        }
    }

    public bool IsGameOver { get { return isGameOver; } }

    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        isGameOver = true;
        ScoreController.Instance.SetHighScore();
        GameOverUI.Show();
    }

}
