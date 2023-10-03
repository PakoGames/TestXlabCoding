using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public void Spawners()
    {

        GetRandomPrefab();


    }

    private GameObject GetRandomPrefab()
    {
        if (prefabs.Length == 0)
        {
            Debug.LogError("Spawner - prefab = null");
            return;
        }

        var index = Random.Range(0, prefabs.Length);
        var prefab = prefabs[index];

        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
