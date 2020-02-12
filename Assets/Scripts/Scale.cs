using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 scaleVector;
    void Start()
    {
        scaleVector = new Vector3(-0.01f, -0.01f, -0.01f);
        Debug.Log("Start the game");
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log("Start the update");
        transform.localScale += scaleVector;
    }
}
