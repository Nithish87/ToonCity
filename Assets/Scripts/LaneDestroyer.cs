using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneDestroyer : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        //print("Collided");

        if (other.gameObject.CompareTag("TrackEnd"))
        {
            print(other.transform.parent.gameObject.name);
            other.transform.parent.gameObject.SetActive(false);

            SetChuck();
        }
    }

    private void SetChuck()
    {
        GameObject _obj=ObjectPool.Instance.GetChunk();

        _obj.transform.position = new Vector3(0, 0, 160);

        _obj.SetActive(true);
    }
}
