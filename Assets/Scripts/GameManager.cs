using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThreshholds;

    public Text scoreText;
    public Text multiText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";

        currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
        
    }

    public void NoteHit()
    {
        Debug.Log("Hit on time");

        if (currentMultiplier - 1 < multiplierThreshholds.Length)
        {
            multiplierTracker++;

            if (multiplierThreshholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;

            }
        }

        multiText.text = "Multiplier: x" + currentMultiplier;

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");
    }
}

