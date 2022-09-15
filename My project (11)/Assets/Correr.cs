using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correr : MonoBehaviour
{
    int velocity = 0;
    int correndo = 15;
    int adando = 10;
    void Update()
    {
        if (Input.GetButton("Fire3"))
            velocity = correndo;
        else
            velocity = adando;
    }
}
