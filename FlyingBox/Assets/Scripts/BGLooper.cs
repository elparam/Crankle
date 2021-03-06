﻿using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

    int numbBGPanels = 6;

    float pipeMax = -0.6643149f;
    float pipeMin = -1.646717f;


    void Start()
    {
        GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");

        foreach(GameObject pipe in pipes)
        {
            Vector3 pos = pipe.transform.position;
            pos.y = Random.Range(pipeMin, pipeMax);
            pipe.transform.position = pos;
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        float widthOfBGObject = ((BoxCollider2D)collider).size.x;
        Vector3 pos = collider.transform.position;
        pos.x += widthOfBGObject * numbBGPanels ;

        if(collider.CompareTag("Pipe"))
        {
            pos.y = Random.Range(pipeMin, pipeMax);
        }

        collider.transform.position = pos;
    }
}
