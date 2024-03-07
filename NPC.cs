using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC Health
    public int health = 5;

    //NPC Level
    public int level = 1;
    
    //NPC Speed
    public float speed = 1f;


    void Start()
    {
        health = health + level;
        print("Lives: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition =
            transform.position;
        newPosition.z += speed *
            Time.deltaTime;
        transform.position = newPosition;
    }
}
