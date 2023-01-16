using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float levelFinishTime = 3f;
    public bool gameFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= levelFinishTime)
        {
            print("Next Level");
            gameFinished = true;
        }
    }
}
