﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class green_balloon : MonoBehaviour
{
    float random_speed;
    public new GameObject animation;
    public GameObject sound;
 

    // Start is called before the first frame update
    void Start()
    {
        float random_position = Random.Range(-10, -1);
        random_speed = Random.Range(1f, 2.5f);

        transform.position = new Vector2(random_position, -6.12f);

        sound = GameObject.Find("SoundManager");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * random_speed * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Finish")
        {
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("laser"))
        {
            Score.ScoreValue++;
            Destroy(this.gameObject);
            Instantiate(animation, transform.position, transform.rotation);
            sound.GetComponent<SoundFX>().PopSound();
           
        }
    }
}
