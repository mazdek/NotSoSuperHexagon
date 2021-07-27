using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    public float rotationSpeed = 1f;
    private int toggle = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Toggle", 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed * toggle);
    }

    void Toggle()
    {
        toggle *= -1;
    }
}
