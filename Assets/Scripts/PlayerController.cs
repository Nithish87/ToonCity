using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int moveDis = 1;

    private int currentLane = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("Pressed");

            if (currentLane != -1)
            {
                transform.position = new Vector3(transform.position.x - moveDis, transform.position.y, transform.position.z);

                currentLane--;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentLane != 1)
            {
                transform.position = new Vector3(transform.position.x + moveDis, transform.position.y, transform.position.z);

                currentLane++;
            }
        }
    }
}
