using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMan : MonoBehaviour
{
  public Transform player;

  private void Update()
  {
    if (player.position.y < -1)
    {
      SceneManager.LoadScene(0);
    }
  }
}
