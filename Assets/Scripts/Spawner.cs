using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabZombie;
    private float _timer = 0;

    private Vector3 _spawnZombiePrefab;
    private void Start()
    {
        _spawnZombiePrefab = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update() 
    {
        _timer += Time.deltaTime;
        if (_timer > 1)
        {
            _timer = 0;
            GameObject zombieJusteSpawn = Instantiate(prefabZombie);
            zombieJusteSpawn.GetComponent<Transform>().position = _spawnZombiePrefab;
        }
    }
}
