using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField]
    float velocity;

    [SerializeField]
    float timeDelete;

    void Start()
    {
        Destroy(gameObject, timeDelete);
    }

    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
