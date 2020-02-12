using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject porta;
    bool doorOpen;
    private Rigidbody rigidBody;
    void Start()
    {
        doorOpen = false;
        porta = GameObject.FindWithTag("door");
        rigidBody=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            rigidBody.AddForce(Vector3.left * 2, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            rigidBody.AddForce(Vector3.right * 2, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            rigidBody.AddForce(Vector3.forward * 2, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            rigidBody.AddForce(Vector3.back * 2, ForceMode.Impulse);
        }

    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Placa")
        {
            Debug.Log("Collision on the Placa");
            if (doorOpen == false)
            {
                Debug.Log("Door Closed");    
                porta.transform.Rotate(0, 90, 0);
                doorOpen=true;
            }



        }
        if (other.gameObject.tag == "CloseDoor")
        {
            Debug.Log("Collision on the closeDoor");
            if (doorOpen == true){
                Debug.Log("Door open");    
                porta.transform.Rotate(0, 90, 0);
                doorOpen=false;

            }
        }


    }

}
