using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    private GameObject PlayerObject;
    private float forceValue = 5f;
    private Vector2 jumpForce;
    private Rigidbody2D rb2D;
    private Playercontroller controller;

    void Start()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
       controller = PlayerObject.GetComponent<Playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerObject == null)
        {
            PlayerObject = GameObject.FindGameObjectWithTag("Player");
            controller = PlayerObject.GetComponent<Playercontroller>();


        }

    }

    public void jump(int value)
    {
        if(controller.isGrounded)
        {
            rb2D = PlayerObject.GetComponent<Rigidbody2D>();

            jumpForce = new Vector2(0, forceValue * value);
            rb2D.AddForce(jumpForce, ForceMode2D.Impulse);
        }
       

    }


}
