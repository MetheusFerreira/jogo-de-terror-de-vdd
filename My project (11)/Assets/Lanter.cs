using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanter : MonoBehaviour
{
    public GameObject lanterna;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            lanterna.SetActive(!lanterna.activeSelf);
        }
    }
}
