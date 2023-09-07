using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "GotHit")
        {
            score++;
            UnityEngine.Debug.Log("you hit a thing " + score + " Many times");
        }
    }
}