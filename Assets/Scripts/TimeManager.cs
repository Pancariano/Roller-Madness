using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private Text timeText;
    [SerializeField] private float levelFinishTime = 3f;
    public bool gameFinished = false;
    public bool gameOver = false;

    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTheTimer();
       

        if (Time.time >= levelFinishTime && gameOver == false)
        {
            
            gameFinished = true;
            winScreen.SetActive(true);
            gameOverScreen.SetActive(false);
        }

        if (gameOver == true)
        {
            gameOverScreen.SetActive(true);
            winScreen.SetActive(false);
        }
    }

    private void UpdateTheTimer()
    {
        timeText.text = "Time " + (int)Time.time;
    }

}
