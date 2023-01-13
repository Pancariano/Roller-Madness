﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    bool isCollided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
           
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isCollided == false)
        {
            //Script'in içinde olduğu nesneye çarpan nesnelerin adını yazdırır
            print(collision.gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.red;
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score--;
            isCollided =true;
        }  
    }
}
