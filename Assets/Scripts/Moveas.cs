using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveas : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody rigidBody;  // 1.-The private variable
    // Start is called before the first frame update
    void Start()
    {
        rigidBody= GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // 3.-Using rigidBodyevery time. Pay attention to the mass of the object!
        rigidBody.AddForce(new Vector3 (Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")));
    }
}
