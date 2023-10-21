using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 3.0f;

    public float turnSpeed = 2.0f;
    public float horizontalInput;

    public float forwardInput;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        //assigns values of -1 to 1 to variable "horizontalInput" based on player input from left and rigth arrows keys.
        horizontalInput = Input.GetAxis("Horizontal");
        //forward input
        forwardInput = Input.GetAxis("Vertical");


    //moves player object forward or horizontal based on player inputs        
        transform.Translate(Vector3.forward  * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }

    // Update is called once per frame
   /* void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.back * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }*/
}
