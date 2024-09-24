using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    void Start()
    {

    }

    void Update()
    {
        //destroys projectile if misses target
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //ends game if animal gets past player
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
