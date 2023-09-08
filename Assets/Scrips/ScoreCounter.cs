using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Hitable")
        {
            score++;
            UnityEngine.Debug.Log("you hit " + score + " things!");
        }
    }
}