using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform target; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        print(target);
    }
}
