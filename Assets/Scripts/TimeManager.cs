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
        if (gameOver == false && gameFinished == false)
        {
            UpdateTheTimer();
        }

       

        if (Time.timeSinceLevelLoad >= levelFinishTime && gameOver == false)
        {
            gameFinished = true;
            winScreen.SetActive(true);
            gameOverScreen.SetActive(false);

            //payer tagine sayip olan tüm objeleri yok et
            foreach (GameObject allObjects in GameObject.FindGameObjectsWithTag("Objects"))
            {
                Destroy(allObjects);
            }
        }

        if (gameOver == true)
        {
            gameOverScreen.SetActive(true);
            winScreen.SetActive(false);

            //payer tagine sayip olan tüm objeleri yok et
            foreach (GameObject allObjects in GameObject.FindGameObjectsWithTag("Objects"))
            {
                Destroy(allObjects);
            }
        }
    }

    private void UpdateTheTimer()
    {
        timeText.text = "Time " + (int)Time.timeSinceLevelLoad;
    }

}
