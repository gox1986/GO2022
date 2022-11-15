using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportScript : MonoBehaviour
{
    public gameMan gm;
    
    public GameObject go2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gm.DoTeleport();
            go2.SetActive(true);
        }
    }
}
