using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Old World!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!");

        // Move the object
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {

        }
    }
}
