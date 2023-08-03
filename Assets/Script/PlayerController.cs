using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{   
    GameObject player;
    //Rigidbody playerRigidbody;
    float playerMovementSpeed;
    float playerRotationSpeed;
    Vector3 _acceleration;
    Vector3 _vel;
    public string noRideTag = "NoRideTag";
    // Start is called before the first frame update
    void Start()
    {
        //player assetÇÉäÉçÅ[Éh
        //player = GameObject.Find("cube");
        
        //playerRigidbody = player.GetComponent<Rigidbody>();
        playerMovementSpeed = 0.5f;
        playerRotationSpeed = 1.2f;
        _acceleration = Vector3.zero;
        _vel = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * playerMovementSpeed;
            //_acceleration += transform.forward * 0.1f;
            //_vel += _acceleration * Time.deltaTime;
            //transform.position = _vel * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * playerMovementSpeed;
            //_acceleration -= transform.forward * 0.1f;
            //_vel += _acceleration * Time.deltaTime;
            //transform.position = _vel * Time.deltaTime;
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
        if (collision.gameObject.name == "Enemy")
        {
            SceneManager.LoadScene("GameoverScene");
            // If a tag collides with an object matching the specified one, ignore the collision and do not ride
            //Physics.IgnoreCollision(GetComponent<Collider>(), collision.collider);
        }
    }
}
