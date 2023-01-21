﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform target;
    [SerializeField] private int enemyFollowSpeed;
    [SerializeField] private float stopDistance;
    private TimeManager timeManager;
    [SerializeField] private GameObject deadEffect;

    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        timeManager = FindObjectOfType<TimeManager>();
    }

    void Update()
    {
        if (timeManager.gameOver == false && timeManager.gameFinished == false)
            MoveTheEnemy();
    }

    private void MoveTheEnemy()
    {
        if (target != null)
        {
            transform.LookAt(target);
            float distance = Vector3.Distance(transform.position, target.position);

            if (distance > stopDistance)
            {
                transform.position += transform.forward * enemyFollowSpeed * Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter(Collision collision) // fiziksel temas var isTrigger kapalı
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            TimeManager timeManager = FindObjectOfType<TimeManager>();
            timeManager.gameOver = true;
        }
    }

    private void OnDisable()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);
    }
}