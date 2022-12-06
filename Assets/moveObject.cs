using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
   public float speed=30;
//    private void Update(){
//     transform.Translate(Vector3.forward * speed *Time.deltaTime, 0, 0);
//    }

    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        this.transform.Translate(0, 0,- Time.deltaTime*speed);
    }

}

// public class moveObject : MonoBehaviour
// {
//     //movement speed in units per second
//     private float movementSpeed = 0.1f;

//     void Update()
//     {
//         //get the Input from Horizontal axis
//         float horizontalInput = Input.GetAxis("Horizontal");

//         //update the position
//         transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, 0);

//         //output to log the position change
//         Debug.Log(transform.position);
//     }
// }
