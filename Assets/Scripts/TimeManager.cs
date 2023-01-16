using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float levelFinishTime = 3f;
    public bool gameFinished = false;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= levelFinishTime && gameOver == false)
        {
            print("Next Level");
            gameFinished = true;
        }

        if (gameOver == true) ;
        {
            print("Restart");
        }
    }
}
