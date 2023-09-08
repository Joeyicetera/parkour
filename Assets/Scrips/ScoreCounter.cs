using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private int coin = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Hitable")
        {
            score++;
            print("you hit " + score + " things!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coin++;
            print("you have " + coin + " coins!");

        }
    }
}