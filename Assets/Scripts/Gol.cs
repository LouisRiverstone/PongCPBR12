using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public GameController gc;
    public string lado;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        gc.Pontuar(lado);
    }

}
