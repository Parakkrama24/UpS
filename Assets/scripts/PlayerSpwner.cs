using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpwner : MonoBehaviour
{
    [SerializeField] private GameObject PlayerPreFab;
    [SerializeField] private float ForceValue = 5f;
    private GameObject[] obstacles;
    private int spawnIndex;
    private GameObject Player;
    private Rigidbody _Rigidbody;
    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        _Rigidbody = GetComponent<Rigidbody>();
        obstacles = GameObject.FindGameObjectsWithTag("Obstacles");

        spawmer();

    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(obstacles.Length);
        obstacles = GameObject.FindGameObjectsWithTag("Obstacles");


        if (Player == null)
        {
            spawmer();
        }
    }

    private void spawmer()
    {
        spawnIndex = Random.Range(0, obstacles.Length);
        Vector2 spawnPotiton = new Vector2(obstacles[spawnIndex].transform.position.x, obstacles[spawnIndex].transform.position.y + 1f);
        Player = Instantiate(PlayerPreFab, spawnPotiton, Quaternion.identity);
    }

    public void playerJump()
    {
        _Rigidbody.AddForce(Vector2.up*ForceValue);
    }

}
