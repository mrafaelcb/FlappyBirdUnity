using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public Transform pipe;

    [SerializeField]
    float timeSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, timeSpawn);
    }

    // Update is called once per frame
    void Update()
    {
                
    }

    void Spawn()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-435f, 188f), -115), Quaternion.identity);
    }
}
