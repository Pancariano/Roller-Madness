using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject restart;
    [SerializeField] private GameObject nextLevel;
    
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        //sıradaki sahnenin indexini almak için kullanıyoruz(sıra numarasını)
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        //SceneManager.sceneCountInBuildSettings bize kaç adet scene varsa onun sayısını verir. Bize sıra sayısı lazım olduğu için -1 kullanırız.
        //2 sahne varsa 2 veriri ama 2. sayının indexi 1'dir sayma sayıları 0'dan başlar
        int sceneIndex = SceneManager.sceneCountInBuildSettings - 1;

        if (nextSceneIndex <= sceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }

        if (nextSceneIndex > sceneIndex)
        {
            SceneManager.LoadScene(0);
        }
    }
}