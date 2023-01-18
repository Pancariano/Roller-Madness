using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float levelFinishTime = 3f;
    public bool gameFinished = false;
    public bool gameOver = false;

    [SerializeField] private Text timeText;

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
            print("Next Level");
            gameFinished = true;
        }

        if (gameOver == true)
        {
            print("Restart");
        }
    }

    private void UpdateTheTimer()
    {
        timeText.text = "Time " + (int)Time.time;
    }

}
