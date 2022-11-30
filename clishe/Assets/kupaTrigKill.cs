using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupaTrigKill : MonoBehaviour
{
    public gameMan gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gm.Restart();
        }
    }
}
