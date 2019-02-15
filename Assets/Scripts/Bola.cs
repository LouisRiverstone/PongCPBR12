using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float x = Random.Range(-10,10);
        float y = Random.Range(-10, 10);
        if (x == 0 || y == 0)
        {
           x = Random.Range(-10, 10);
           y = Random.Range(-10, 10);
        }

        rb.velocity = new Vector2(x,y);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
