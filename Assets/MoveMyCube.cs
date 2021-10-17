using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMyCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float speed = 10;
    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(new Vector3(h, 0, v));
        if (Input.GetMouseButton(0))
            transform.rotation *= Quaternion.Euler(0f, 50f * Time.deltaTime, 0f);

    }
}