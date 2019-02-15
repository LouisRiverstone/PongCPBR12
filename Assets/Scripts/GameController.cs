using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    int pontosA = 0;
    int pontosB = 0;
    bool jogoIniciou = false;
    public GameObject bola;
    public Text pontosText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !jogoIniciou)
        {
            Instantiate(bola);
            jogoIniciou = true;
        }
    }

    public void Pontuar(string lado) {
        if (lado == "a")
        {
            pontosB++;
        }
        else
        {
            pontosA++;
        }
        jogoIniciou = false;
        pontosText.text = pontosA + " : " + pontosB;
    }
}
