using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float obstacleSpawnTimer = 1f;

    private float timer;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            var obs = Instantiate(obstacle, new Vector3(14, Random.Range(-2, 3), 0), Quaternion.identity);

            obs.transform.parent = transform;

            timer = obstacleSpawnTimer;
        }
    }

    



}
