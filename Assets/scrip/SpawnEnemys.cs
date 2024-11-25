using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject navePrefab;
    public float spawnInterval = 3f;
    public float xMin = -8f;
    public float xMax = 8f;
    public float ySpawnPosition = 5f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            float xPosition = Random.Range(xMin, xMax);
            Vector2 spawnPosition = new Vector2(xPosition, ySpawnPosition);
            Instantiate(navePrefab, spawnPosition, transform.rotation);
            timer = 0f;
        }
    }
}

