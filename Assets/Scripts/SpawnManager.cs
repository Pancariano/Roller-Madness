using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float spawnRate = 5f;
    private float nextSpawnTime = 0;
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject[] objectToSpawn;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime += spawnRate;
            SpawnObject(objectToSpawn[RandomObjectNumber()], spawnPositions[RandomSpawnNumber()]);
        }
    }

    private void SpawnObject(GameObject gameObject, Transform newTransform)
    {
        Instantiate(gameObject, newTransform.position, newTransform.rotation);
    }

    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnPositions.Length);
    }

    private int RandomObjectNumber()
    {
        return Random.Range(0, objectToSpawn.Length);
    }
}