using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Colors { 
    BASE,
    RED,
    GREEN,
    BLUE,
    WBLUE,
    PINK,
    YELLOW,
    ORANGE,
    PURPLE
};

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public static PlayerController Player;

    private Rigidbody rb; 
    public float Speed = 5.0f; 
    public float JumpStrange = 5.0f;
    public Colors CurrentColor { get; set; } = Colors.BASE;

    private bool isJump = true;
    private bool isMenu = false;

    void Start()
    {
        Player = this;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveH = Input.GetAxis("Horizontal"); 
        float moveV = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!isMenu)
            {
                UIController.GetUI().UIOn();
                isMenu = true;
            }
            else 
            {
                UIController.GetUI().UIOff();
                isMenu = false;
            }
        }

        transform.Translate(Vector3.forward * moveV * Speed * Time.deltaTime); 
        transform.Rotate(Vector3.up * moveH * 90f * Speed * Time.deltaTime); 

        if (Input.GetButton("Jump") && isJump == false)  
        {
            isJump = true;
            rb.velocity += Vector3.up * JumpStrange; 
        }

        if (Input.GetKeyDown(KeyCode.Q)) {
            switch (CurrentColor) {
                case Colors.BASE:
                    CurrentColor = Colors.RED;
                    break;
                case Colors.RED:
                    CurrentColor = Colors.GREEN;
                    break;
                case Colors.GREEN:
                    CurrentColor = Colors.BLUE;
                    break;
                case Colors.BLUE:
                    CurrentColor = Colors.WBLUE;
                    break;
                case Colors.WBLUE:
                    CurrentColor = Colors.PINK;
                    break;
                case Colors.PINK:
                    CurrentColor = Colors.YELLOW;
                    break;
                case Colors.YELLOW:
                    CurrentColor = Colors.ORANGE;
                    break;
                case Colors.ORANGE:
                    CurrentColor = Colors.PURPLE;
                    break;
                case Colors.PURPLE:
                    CurrentColor = Colors.BASE;
                    break;
            }
            Debug.Log(CurrentColor);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform") {
            isJump = false;
        }
    }
}
