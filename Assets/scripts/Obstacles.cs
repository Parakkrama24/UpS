using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D rb2;
    void Start()
    {
        rb2= gameObject.AddComponent<Rigidbody2D>();
        rb2.isKinematic = true;
    }

  
    void Update()
    {
        if (transform.position.y < -5f)
        {
          Destroy(this.gameObject); 
        }
    }

    private void FixedUpdate()
    {
        rb2.velocity = new Vector2(0,-speed*Time.deltaTime);

    }
}
