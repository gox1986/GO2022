using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotandCol : MonoBehaviour
{
    public gameMan gman;
    public int _rotationSpeed = 15;

    void Update () {

        // Rotation on y axis
        // be sure to capitalize Rotate or you'll get errors
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gman.AddCoins();
    }
}
