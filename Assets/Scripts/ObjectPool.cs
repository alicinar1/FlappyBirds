using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private Queue<GameObject> objectsInPool;
    [SerializeField] private int poolSize;
    [SerializeField] private GameObject objectPrefab;

    private void Awake()
    {
        objectsInPool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);

            obj.SetActive(false);

            objectsInPool.Enqueue(obj);
        }
    }

    public GameObject GetObjectInPool()
    {
        GameObject obj = objectsInPool.Dequeue();

        obj.SetActive(true);

        objectsInPool.Enqueue(obj);

        return obj;
    }
}
