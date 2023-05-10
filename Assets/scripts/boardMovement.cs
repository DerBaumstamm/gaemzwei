using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardMovement : MonoBehaviour
{
    private float rotationX = 0f;
    private float rotationY = 0f;
    private float rotationZ = 0f;
    private float rotationLimit = 15;
    private float rotationSpeed = 0.2f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && rotationX <= rotationLimit)
        {
            rotationX += rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
        }

        if (Input.GetKey(KeyCode.S) && rotationX >= -rotationLimit)
        {
            rotationX += -rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
        }

        if (Input.GetKey(KeyCode.A) && rotationZ <= rotationLimit)
        {
            rotationZ += rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
        }

        if (Input.GetKey(KeyCode.D) && rotationZ >= -rotationLimit)
        {
            rotationZ += -rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
        }
    }
}
