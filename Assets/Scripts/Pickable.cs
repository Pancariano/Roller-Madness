using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public int scoreAmount = 2;
    [SerializeField] private GameObject deadEffect;

    private void OnTriggerEnter(Collider other) // fiziksel temas yok isTrigger açık
    {
        //sahnedeki ScoreManager component’ine sahip objeyi bulur ve bu objenin ScoreManager component’ini döndürür.
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.score += scoreAmount;
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision) // fiziksel temas var isTrigger kapalı
    {
        if (collision.gameObject.tag == "Player")
        {
            //sahnedeki ScoreManager component’ine sahip objeyi bulur ve bu objenin ScoreManager component’ini döndürür.
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score += scoreAmount;
            Destroy(gameObject);
        }
    }

    private void OnDisable()
    {
        Instantiate(deadEffect,transform.position,transform.rotation);
    }
}