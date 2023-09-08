using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private float SpinSpeed;
    [SerializeField] private float SpinSpeedModifier = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpinSpeed = Time.deltaTime * SpinSpeedModifier;
        transform.Rotate(0, SpinSpeed, 0);
    }
}
