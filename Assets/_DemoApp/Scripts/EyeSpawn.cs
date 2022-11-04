using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject Eye;

    void Start()
    {
        
    }

    void Update()
    {
        
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(Eye, spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}
