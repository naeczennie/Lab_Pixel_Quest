using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geo_Controller : MonoBehaviour
{
    //string String = "Hello ";
    //int pizza = 3;
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene_2";
    // Start is called before the first frame update
    void Start()
    {
        //string String2 = "World";
        //Debug.Log(String + String2);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(pizza);
        //pizza ++;
        // transform.position = transform.position + new Vector3(0.005f, 0, 0);
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //transform.position += new Vector3(0, 1, 0);
        //}
        if (Input.GetKeyDown(KeyCode.A))
        {
            // rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, -1, 0);
        //}
        if (Input.GetKeyDown(KeyCode.D))
        {
            // rb.velocity = new Vector2(1, rb.velocity.y);
        }
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    // Debug.Log("Player Has Died");
                    string ThisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(ThisLevel);
                    break;
                }
            // Debug.Log("Hit");
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}