using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actKupa : MonoBehaviour
{
   public GameObject kupa;
   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Player")
      {
        kupa.SetActive(true); 
      }
   }
}
