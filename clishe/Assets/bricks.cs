using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
   public GameObject go;
   private void OnTriggerEnter(Collider other)
   {
      go.SetActive(false);
   }
}
