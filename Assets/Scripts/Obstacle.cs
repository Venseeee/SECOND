﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update

    PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }


    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerMovement.Die();
        }
    }
        void Update()
    {
        
    }
}
