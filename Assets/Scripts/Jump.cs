using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int jumpValue= 2;  
    private Rigidbody rigidBody;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody=GetComponent<Rigidbody>();
        audioSource= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // An impulse (jump), no a constant force. The space bar, by default// Second condition: To avoid jumping in the air
        if (Input.GetButtonDown("Jump") ) {
            // Adding force on the y axis: Jumping. Impulse: An instant value for the speed. 
            // Instant force: Update is a good method to apply
             rigidBody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
             audioSource.Play();
             }
             //else if(Mathf.Abs(rigidBody.velocity.y) < 0.01f){

             //rigidBody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);


             
             
    }
}
