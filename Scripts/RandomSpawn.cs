using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject cubePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-500, 500), 2, Random.Range(-500, 500));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }
    }


}
