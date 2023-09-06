using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float inputHorizontal = 0;
    private float inputVertical = 0;
    private float inputJump = 0;

    [SerializeField] float HorizontalSpeedModifier = 1;
    [SerializeField] float VerticalSpeedModifier = 1;
    [SerializeField] float JumpSpeedModifier = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSpeedModifier;
        inputVertical = Input.GetAxis("Vertical") * Time.deltaTime * VerticalSpeedModifier;
        inputJump = Input.GetAxis("Jump") * Time.deltaTime * JumpSpeedModifier;
        
        transform.Translate(inputHorizontal,inputJump,inputVertical);
    }
}
