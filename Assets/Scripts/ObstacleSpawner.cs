using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float obstacleSpawnTimer = 1f;
    [SerializeField] private ObjectPool objectPool;


    private float timer;
    
    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            GameObject obs = objectPool.GetObjectInPool();

            obs.transform.position = new Vector3(14, Random.Range(-2, 3), 0);

            obs.transform.parent = transform;

            timer = obstacleSpawnTimer;
        }
    }

    



}
