using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//example change
public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(1, 1, 24);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        //follow player and offset camera in front of player by (1, 1, 24)
        transform.position = player.transform.position + offset;
    }
}
