using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public int scoreAmount = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //sahnedeki ScoreManager component’ine sahip objeyi bulur ve bu objenin ScoreManager component’ini döndürür.
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.score += scoreAmount;
        Destroy(gameObject);
    }

}
