using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetections : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //destroys game objects when they collide
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
