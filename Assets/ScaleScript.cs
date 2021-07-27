using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScaleScript : MonoBehaviour
{
    Rigidbody2D rb;

    public float scaleSpeed = 3.3f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 17f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;

        if (transform.localScale.x < 0.01f)
            Destroy(gameObject);
    }
}
