using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabsBird;
    [SerializeField] private float spawnTime = 2.0f;
    [SerializeField] private Transform parrentBird;
    [SerializeField] private Transform parrentPosition;

    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            Vector3 positionSpawn = parrentPosition.position;
            positionSpawn.y = Random.Range(-21f, 21f);
            positionSpawn.x = Random.Range(-38f, 38f);
            Instantiate(prefabsBird, positionSpawn, Quaternion.identity, parrentBird);
            spawnTime = 2f;

        }

    }
}
