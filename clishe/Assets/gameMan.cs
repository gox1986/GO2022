using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMan : MonoBehaviour
{
  public Transform player;
  public int coins;
  public TextMeshProUGUI text;

  private void Start()
  {
    text.text = "Coins: 0";
  }

  private void Update()
  {
    if (player.position.y < -1)
    {
      SceneManager.LoadScene(0);
    }
  }

  public void AddCoins()
  {
    coins++;
    text.text = "Coins: " +coins.ToString();
  }
}
