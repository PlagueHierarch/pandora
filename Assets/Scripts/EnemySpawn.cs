using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnTime;

    private void Awake()
    {
        spawnTime = 5;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnTime, 1);
    }

    private void Spawn()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
        Debug.Log("Enemy Spawned");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
