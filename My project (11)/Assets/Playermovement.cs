using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 0f;
    public float correndo = 20f;
    public float adando = 10f;

    void Update()
    {
        Movement();
        if (Input.GetButton("Fire3"))
        {
            speed = correndo;
        }
        else
        {
            speed = adando;
        }
            
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        move += Physics.gravity;
        controller.Move(move * speed * Time.deltaTime);


    }
}
