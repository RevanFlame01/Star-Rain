using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsSpawner : MonoBehaviour
{
    public GameObject[] obj;
    private float _time = 1f;
    private Vector3 spawnPosition;
   
    
    private void Update()
    {
        _time -= 1f * Time.deltaTime;
        if (_time <= 0)
        {
            Spawner();
            _time = 2f;
        }

    }

    public void Spawner()
    {
        for (int i = 0; i < 1; i++)
        {
            spawnPosition = new Vector3(Random.Range(-0.5f, 0.5f), 3.5f, 0);
            Instantiate(obj[Random.Range(0, obj.Length)], spawnPosition, Quaternion.identity);
        }
    }
    
}
