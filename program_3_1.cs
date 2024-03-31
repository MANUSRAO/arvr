using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherescript : MonoBehaviour
{
    // Start is called before the first frame update
    public PhysicMaterial physic;
    public float levelTime = 10f;
    private float startTime = 0f;
    void Start()
    {
        physic.bounciness = 0.5f;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0,5,0);
    }

    void Update(){
        startTime += Time.deltaTime;
        if(startTime>levelTime)
            physic.bounciness = 1.0f;
    }
}
