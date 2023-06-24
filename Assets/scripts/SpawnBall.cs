using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;

    void Start()
    {
        Instantiate(ballPrefab, transform.position, Quaternion.identity);
    }
}
