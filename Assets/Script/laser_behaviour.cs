﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_behaviour : MonoBehaviour
{
    AudioSource SFX;

    private void Start()
    {
        SFX = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * 0.3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Collider")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "blue" || collision.tag == "green")
        {
            SFX.Play();
            Destroy(this.gameObject);
        }    
    }


}
