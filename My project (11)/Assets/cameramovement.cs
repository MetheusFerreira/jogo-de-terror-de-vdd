using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public float mouseSpeed = 100f;
    public Transform playerbody;
    float xRotation = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
        xRotation -= mouseY;
        if (xRotation < -90f)
        {
            xRotation = -90;
        }
        else if (xRotation > 90f)
        {
            xRotation = 90f;
        }
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
