using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BoardMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float rotationX = 0f;
    private float rotationZ = 0f;

    [SerializeField]
    private int rotationLimit = 30;

    [SerializeField]
    private float rotationSpeed = 30f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {        
        //rotationZ = Input.GetAxis("Horizontal");;
        rotationX = Mathf.Lerp(rotationX, Input.GetAxis("Vertical") * rotationLimit, rotationSpeed * Time.deltaTime);
        rotationZ = Mathf.Lerp(rotationZ, Input.GetAxis("Horizontal") * rotationLimit, rotationSpeed * Time.deltaTime);
        rb.MoveRotation(Quaternion.Euler(rotationX , 0, -rotationZ));

    }
}
