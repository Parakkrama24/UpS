using System;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpMagnitude = 15f;
    private Rigidbody2D rb2D;
    private Vector2 jumpForce;
    private FixedJoystick joystick;
    [NonSerialized] public bool isGrounded;

    void Start()
    {
       joystick = GameObject.FindAnyObjectByType<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
        }

        // Example jump input, you might want to replace this with your actual input
    }

    void FixedUpdate()
    {
        Debug.Log(joystick.Horizontal);
        if (joystick.Horizontal >0.2 || joystick.Horizontal<-0.2)
        {
            transform.Translate(Vector2.right * joystick.Horizontal * speed * Time.deltaTime);
        }
        // Example ground check
       
        Debug.Log("IsGrounded: " + isGrounded);
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            isGrounded = true;
 
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            isGrounded = false;
           // rigidbody2.gravityScale = _gravityScale;
        }
    }

}