using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Van_Controller : MonoBehaviour
{
     private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(rb.transform.forward * 2.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(rb.transform.forward * -2.5f);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(Vector3.down, 0.8f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(Vector3.up, 0.8f);
        }
    }
}
