using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private Text scoreText;
        

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTheScore();
        print(score);

    }

    private void UpdateTheScore()
    {
        scoreText.text = "Score " + score.ToString();
    }
}