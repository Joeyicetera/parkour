using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        score++;
        UnityEngine.Debug.Log("you hit a thing " + score + " Many times");
    }

}
