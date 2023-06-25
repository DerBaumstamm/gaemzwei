using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;
    private float moveX;
    private float moveY;
    private float moveZ;

    [SerializeField]
    private int cameraSpeed = 5;
    void Start()
    {
        offset.x = transform.position.x - ball.transform.position.x;
        offset.y = transform.position.y - ball.transform.position.y;
        offset.z = transform.position.z - ball.transform.position.z;
    }
    void LateUpdate()
    {
        //transform.position = ball.transform.position + offset;
        moveX = Mathf.Lerp(transform.position.x, ball.transform.position.x + offset.x, cameraSpeed * Time.deltaTime);
        moveY = Mathf.Lerp(transform.position.y, ball.transform.position.y + offset.y, cameraSpeed * Time.deltaTime);
        moveZ = Mathf.Lerp(transform.position.z, ball.transform.position.z + offset.z, cameraSpeed * Time.deltaTime);
        transform.position = (new Vector3(moveX, moveY, moveZ));
    }
}
