using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float moveInput;
    [SerializeField] private Rigidbody2D Rb;
    [SerializeField] private GameObject RightHand;
    private bool FacePos = true;



    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        JoyStick joystick = FindObjectOfType<JoyStick>();
        Rb.velocity = new Vector2(joystick.Position.y * jumpForce, Rb.velocity.y);
        Vector3 rotation = new Vector3(joystick.Position.x * Speed, joystick.Position.y * jumpForce, 0f);
        transform.Translate(rotation);
        if (FacePos == false && joystick.Position.x > 0f)
        {
            Mirror();
        }
        else if (FacePos == true && joystick.Position.x < 0f)
        {
            Mirror();
        }


        /*transform.Translate(joystick.Position * Speed);*/



        /*float rotationInput = joystick.Position.x;
        float rotationSpeed = 100f;
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;*/


        /*moveInput = Input.GetAxis("Horizontal");
        Rb.velocity = new Vector2(moveInput * Speed, Rb.velocity.y)*/
    }

    void Mirror()
    {
        FacePos = !FacePos;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
