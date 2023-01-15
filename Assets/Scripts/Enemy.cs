using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int enemyFollowSpeed;
    Transform target;
    [SerializeField] private float stopDistance;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);

        if(distance > stopDistance)
            transform.position += transform.forward * enemyFollowSpeed * Time.deltaTime;
        
    }
}
