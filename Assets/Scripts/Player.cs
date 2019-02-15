using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Moviment();
    }

    void Moviment() {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, 1) * speed;
        }else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -1) * speed;
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
