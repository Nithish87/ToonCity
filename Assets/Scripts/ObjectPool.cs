using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    [SerializeField] private List<GameObject> chunks = new List<GameObject>();

    private int amount = 7;

    private List<GameObject> pooledChunks = new List<GameObject>();

    private void Awake()
    {
        Instance = this;

        for (int i = 0; i < amount; i++)
        {
            GameObject _obj = Instantiate(chunks[i],transform);

            _obj.SetActive(false);

            pooledChunks.Add(_obj);
        }
    }

    private void Start()
    {
        for(int i = 0; i < amount; i++)
        {
            pooledChunks[i].transform.position = new Vector3(0, 0, (i * 27));

            pooledChunks[i].SetActive(true);
        }
    }

    public GameObject GetChunk()
    {
        foreach (var obj in pooledChunks)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }
}
