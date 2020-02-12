using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // For the Text class
public class TextStart : MonoBehaviour
{
    public Text missatge;
    // Start is called before the first frame update
    void Start()
    {
        missatge=GetComponent<Text>();
        missatge.text="Start";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
