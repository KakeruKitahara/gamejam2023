using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    GameObject player;
    //Rigidbody playerRigidbody;
    float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //player assetÇÉäÉçÅ[Éh
        //player = GameObject.Find("cube");
        
        //playerRigidbody = player.GetComponent<Rigidbody>();
        playerSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * playerSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * playerSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,Input.GetAxis("Horizontal"),0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0));
        }
    }

    
}
