using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpwner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePreFab;
        

    private GameObject[] objectSpwner;
    private int spwnerPoint;
    void Start()
    {
        objectSpwner = GameObject.FindGameObjectsWithTag("spwnerPoints");
        Debug.Log(objectSpwner.Length);
        InvokeRepeating("spwner", 1f, 1.2f);
    }

   
    private void spwner()
    {
        spwnerPoint= Random.Range(0, objectSpwner.Length);
        Instantiate(obstaclePreFab, objectSpwner[spwnerPoint].transform.position,Quaternion.identity);
    }
}//class
