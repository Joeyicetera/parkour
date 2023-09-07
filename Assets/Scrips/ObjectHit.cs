using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.tag = "GotHit";
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
