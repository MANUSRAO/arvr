using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            this.transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        if(Input.GetKey(KeyCode.RightArrow))
            this.transform.position += Vector3.back * Time.deltaTime * moveSpeed;
    }
}
