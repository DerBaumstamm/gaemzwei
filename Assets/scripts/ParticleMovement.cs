using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{
    public GameObject ball;
    void Update()
    {
        transform.position = ball.transform.position;
    }
}
