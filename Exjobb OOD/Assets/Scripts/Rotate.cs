using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float radiansPerSecond;

    void Update()
    {
        transform.Rotate(Vector3.up, radiansPerSecond * Mathf.Rad2Deg * Time.deltaTime);
    }
}
