using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalController : MonoBehaviour
{
    [SerializeField] ParticleSystem movemetpartical;
    [Range(0f, 10f)]
    [SerializeField] private int occureAftervelocity;

    [Range(0, 0.2f)]
    [SerializeField] private float dustFprmationPeriod;

     private Rigidbody2D playerRb;
    private GameObject player;
    
    float counter;
    void Start()
    {
       player= GameObject.FindGameObjectWithTag("Player");
        playerRb= player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (Mathf.Abs(playerRb.velocity.x) < occureAftervelocity)
        {
            if (counter > dustFprmationPeriod)
            {
                movemetpartical.Play();
                counter = 0;
            }
        }
    }
}
