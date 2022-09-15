using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{
    public GameObject mapa;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mapa.SetActive(!mapa.activeSelf);
        }
    }
}