using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private static AudioController _instance = null;

    public static AudioController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AudioController>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: SoundManager not Found");
                }
            }

            return _instance;
        }
    }

    public AudioClip scoreNormal;
    public AudioClip scoreCombo;

    public AudioClip wrongMove;

    public AudioClip tap;

    private AudioSource player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayScore(bool isCombo)
    {
        if (isCombo)
        {
            player.PlayOneShot(scoreCombo);
        }
        else
        {
            player.PlayOneShot(scoreNormal);
        }
    }

    public void PlayWrong()
    {
        player.PlayOneShot(wrongMove);
    }

    public void PlayTap()
    {
        player.PlayOneShot(tap);
    }
}
