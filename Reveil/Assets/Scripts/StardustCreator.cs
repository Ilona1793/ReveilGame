using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StardustCreator : MonoBehaviour
{
    public float SpawnRate = 4f;
    public GameObject Prefab;
    public float MaxY = 2f;
    public float MinY = -2f;
    public int PoolSize = 5;

    private GameObject[] objectPool;
    private float timeSinceLastSpawn = 0f;
    private int currentObjectIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        objectPool = new GameObject[PoolSize];

        for (int i = 0; i < PoolSize; i++)
        {
            GameObject newObject = Instantiate(Prefab, new Vector4(20f, 20f, 0), Quaternion.identity);
            objectPool[i] = newObject;
            newObject.SetActive(false);
        }

        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.IsGameOver) return;

        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= SpawnRate)
        {
            SpawnObstacle();
            timeSinceLastSpawn = 0f;
        }
    }

    private void SpawnObstacle()
    {
        float randomY = Random.Range(MinY, MaxY);
        Vector3 spawnPosition = new Vector3(5f, randomY, 0f);

        objectPool[currentObjectIndex].transform.position = spawnPosition;
        objectPool[currentObjectIndex].SetActive(true);

        currentObjectIndex += 1;
        if (currentObjectIndex >= objectPool.Length) currentObjectIndex = 0;

    }
}
