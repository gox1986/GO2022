using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHEST : MonoBehaviour
{
   public Animator an;

   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Player")
      {
         an.SetTrigger("New Trigger");
      }
      
   }
}
