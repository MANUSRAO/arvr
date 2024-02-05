using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geoTransform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
            this.transform.position += Vector3.up * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            this.transform.position += Vector3.down * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            this.transform.Rotate(Vector3.up, -1);

        if (Input.GetKey(KeyCode.D))
            this.transform.Rotate(Vector3.up, 1);

        if (Input.GetKey(KeyCode.X))
            this.transform.localScale += new Vector3(1, 0, 0)*Time.deltaTime;

        if (Input.GetKey(KeyCode.Y))
            this.transform.localScale += new Vector3(0, 1, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.Z))
            this.transform.localScale += new Vector3(0, 0, 1) * Time.deltaTime;
    }
}
