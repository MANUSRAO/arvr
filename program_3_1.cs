using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    public float force =600f;
    void Start()
    {
       // GetComponent<Rigidbody2D>().AddForce(new Vector2(20f,10f) * force* Time.deltaTime);
       GetComponent<Rigidbody>().velocity=new Vector3(0,5,0);
    }

}
