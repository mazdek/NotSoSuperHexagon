using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorScript : MonoBehaviour
{
    public GameObject hexagonPrefab;
    public GameObject pentagonPrefab;
    public GameObject squarePrefab;
    public float createTime = 1.1f;
    private float createDuration = 0f;

    // Update is called once per frame
    void Update()
    {
        if( Time.time >= createDuration)
        {
            if(Random.Range(0, 2) % 2 == 1)
                Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            else
                Instantiate(pentagonPrefab, Vector3.zero, Quaternion.identity);
           
            createDuration = Time.time + 1.0f / createTime;
        }
        

    }
}
