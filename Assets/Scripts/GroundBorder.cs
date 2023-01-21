using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class GroundBorder : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (other.tag == "Player")
        {
            FindObjectOfType<TimeManager>().gameOver=true;
        }
    }
}