using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkMovement : MonoBehaviour
{
    private int roadSpeed = 5;

    private void Update()
    {
        transform.Translate(Vector3.back * roadSpeed * Time.deltaTime);
    }
}
