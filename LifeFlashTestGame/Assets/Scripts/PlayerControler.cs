using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

     public float horizontalInput;
    public float speedHorizontal = 15.0f;
    public float XRange = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //sets boundary for x axis. If position less than -10, then set position for X as -10, and keep "y" and "z" positions the same as they are. 10 is set in variable XRange. include "-" before varaible "Xrange" to make it negative.
        /*if(transform.position.x < -XRange)
        {
            transform.position = new Vector3(-XRange, transform.position.y, transform.position.z);

        }

          if(transform.position.x < XRange)
        {
            transform.position = new Vector3(XRange, transform.position.y, transform.position.z);

        }*/


        horizontalInput = Input.GetAxis("Horizontal");




        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speedHorizontal);
        
    }
}
