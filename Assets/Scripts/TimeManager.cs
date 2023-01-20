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
    [SerializeField] private List<GameObject> destroyAfterGame;
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
            UpdateObjects("Enemy");
            UpdateObjects("Objects");
            //destroyAfterGame listesi içerisindeki bütün objeleri yok et
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
        }

        if (gameOver == true)
        {
            gameOverScreen.SetActive(true);
            winScreen.SetActive(false);
            UpdateObjects("Enemy");
            UpdateObjects("Objects");
            //destroyAfterGame listesi içerisindeki bütün objeleri yok et
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
        }
    }

    private void UpdateObjects(string tag)
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag));
    }

private void UpdateTheTimer()
    {
        timeText.text = "Time " + (int)Time.timeSinceLevelLoad;
    }
}