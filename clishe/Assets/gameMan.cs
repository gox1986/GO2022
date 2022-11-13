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
  public GameObject gameObjectt;

  private void Start()
  {
    text.text = "";
  }

  private void Update()
  {
    if (player.position.y < -10)
    {
      SceneManager.LoadScene(0);
    }
  }

  public void AddCoins()
  {
    coins++;
    if (coins == 1)
    {
      gameObjectt.SetActive(true);
      text.text = "Always try to be good person\n and use W-A-S-D to move";
      StartCoroutine(wait());
    }
  
    if (coins == 2)
    {
      gameObjectt.SetActive(true);
      text.text = "If you are feeling down\n grab to anything you can. Jump to space";
      StartCoroutine(wait());
    }
    if (coins == 3)
    {
      gameObjectt.SetActive(true);
      text.text = "Admit when you are wrong\n Don't slide trough lies. Like you can on walls";
      StartCoroutine(wait());
    }
  }

  IEnumerator wait()  
  {
    yield return new WaitForSeconds(10);
    text.text = "";
    gameObjectt.SetActive(false);
  }
}
