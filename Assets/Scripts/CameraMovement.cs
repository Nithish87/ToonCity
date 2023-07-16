using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 3.07999992f, -2.27999997f);

    private float playerLastY = 0;

    [SerializeField] private GameObject Player;

    private void LateUpdate()
    {
        if(Player.transform.position.y != playerLastY)
        {
            transform.position = Player.transform.position + offset;
        }
    }
}
