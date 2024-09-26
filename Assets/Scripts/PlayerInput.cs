using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            Debug.Log("Up");
        
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down");

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Left");

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Right");

        }


    }
}
