using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private float inputHorizontal = 0;
    private float inputVertical = 0;
    private float inputJump = 0;

    [Header("Speed modifiers")]
    [SerializeField] float HorizontalSpeedModifier = 1;
    [SerializeField] float VerticalSpeedModifier = 1;
    [SerializeField] float JumpSpeedModifier = 1;

    Vector2 turn;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer()
    {
        inputHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSpeedModifier;
        inputVertical = Input.GetAxis("Vertical") * Time.deltaTime * VerticalSpeedModifier;
        inputJump = Input.GetAxis("Jump") * Time.deltaTime * JumpSpeedModifier;
        
        transform.Translate(inputHorizontal,inputJump,inputVertical);
    }

    void RotatePlayer()
    {
        turn.x += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);
    }
}
