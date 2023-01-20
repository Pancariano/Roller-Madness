using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private Text scoreText;
    private TimeManager timeManager;

    void Start()
    {
        timeManager = FindObjectOfType<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeManager.gameOver == false && timeManager.gameFinished == false)
        {
            UpdateTheScore();
            print(score);
        }
            

    }

    private void UpdateTheScore()
    {
        scoreText.text = "Score " + score.ToString();
    }
}