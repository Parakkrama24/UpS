using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpwner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePreFab;
    [SerializeField] private float spawnTime=2f;
    [SerializeField] private float timeFraction=0.2f;


    private GameObject[] objectSpwner;
    private int spwnerPoint;
    void Start()
    {
        objectSpwner = GameObject.FindGameObjectsWithTag("spwnerPoints");
       
        InvokeRepeating("spwner", 1f, spawnTime);
    }

    private void Update()
    {
        spawnTime += Time.deltaTime;
        Debug.Log(spawnTime);
    }


    private void spwner()
    {
        spwnerPoint= Random.Range(0, objectSpwner.Length);
        Instantiate(obstaclePreFab, objectSpwner[spwnerPoint].transform.position,Quaternion.identity);
    }
}//class
