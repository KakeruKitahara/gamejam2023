using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    GameObject player;
    //Rigidbody playerRigidbody;
    float playerMovementSpeed;
    float playerRotationSpeed;
    public string noRideTag = "NoRideTag";
    // Start is called before the first frame update
    void Start()
    {
        //player assetÇÉäÉçÅ[Éh
        //player = GameObject.Find("cube");
        
        //playerRigidbody = player.GetComponent<Rigidbody>();
        playerMovementSpeed = 0.5f;
        playerRotationSpeed = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * playerMovementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * playerMovementSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,playerRotationSpeed*Input.GetAxis("Horizontal"),0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, playerRotationSpeed * Input.GetAxis("Horizontal"), 0));
        }
    }

    // Specify an object that cannot be ridden with a tag
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(noRideTag))
        {
            // If a tag collides with an object matching the specified one, ignore the collision and do not ride
            //Physics.IgnoreCollision(GetComponent<Collider>(), collision.collider);
        }
    }
}
