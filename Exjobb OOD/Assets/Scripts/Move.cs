using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;
    private float timeMoved;

    void Update()
    {
        float deltaTime = Time.deltaTime;
        timeMoved += deltaTime;
        if (timeMoved > 1.1f)
        {
            moveSpeed = -moveSpeed;
            timeMoved = 0;
        }
        transform.position += Vector3.up * deltaTime * moveSpeed;   
    }
}
