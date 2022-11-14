using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupaSc : MonoBehaviour
{
    public Transform target;
    public float t;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.Lerp(a, b, t*Time.deltaTime);
    }
}
