using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigggg : MonoBehaviour
{
  public GameObject go;
  public GameObject go1;
  public GameObject go2;
  public GameObject go3;
  public GameObject go4;
  public GameObject go5;
  public GameObject go6;

  private void OnTriggerEnter(Collider other)
  {
      if (other.tag == "Player")
      {
          go.SetActive(true);
      }
  }

  private void OnTriggerExit(Collider other)
  {
      if (other.tag == "Player")
      {
          go.SetActive(false);
      }
  }
}
