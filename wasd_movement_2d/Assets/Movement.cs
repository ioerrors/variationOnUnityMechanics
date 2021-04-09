﻿using UnityEngine;


// added diagonal movement
public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        // "q" can be replaced with any key
        // this section moves the character left and up
        if (Input.GetKey("q"))
        {
            pos.x -= speed * Time.deltaTime;
            pos.y += speed * Time.deltaTime;
        }

        // "e" can be replaced with any key
        // this section moves the character right and up
        if (Input.GetKey("e"))
        {
            pos.x += speed * Time.deltaTime;
            pos.y += speed * Time.deltaTime;
        }

        // "z" can be replaced with any key
        // this section moves the character left and down
        if (Input.GetKey("z"))
        {
            pos.x -= speed * Time.deltaTime;
            pos.y -= speed * Time.deltaTime;
        }

        // "c" can be replaced with any key
        // this section moves the character right and down
        if (Input.GetKey("c"))
        {
            pos.x += speed * Time.deltaTime;
            pos.y -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
