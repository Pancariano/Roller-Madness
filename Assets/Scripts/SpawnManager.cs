using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float spawnRate = 5f;
    private float nextSpawnTime = 0;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] spawnPositions;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime += spawnRate;
            SpawnObject(coinPrefab, transform);
        }
    }

    private void SpawnObject(GameObject gameObject, Transform newTransform)
    {
        Instantiate(gameObject, newTransform.position, newTransform.rotation);
    }
}