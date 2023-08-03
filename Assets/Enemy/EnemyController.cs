using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Camera camera;
    public NavMeshAgent NMAgent;
    public Transform Destiny;
    Vector3 Destination, Origination,playerPosition;
    private Transform PlayerSpot;
    bool inOrigination = true, ChasingPlayer = false;
    public Material sensorMaterial;
    [SerializeField] public Color sensorAlertColor;
    Color sensorColor;
    
    // Start is called before the first frame update
    void Start()
    {
        Origination = transform.position;
        Destination = Destiny.position;
        sensorColor = sensorMaterial.color;
        playerPosition = new Vector3(-1,0, 3);
        GameEvents.current.onAlert += onAlertMode;
    }

    // Update is called once per frame
    void Update()
    {
        if(!ChasingPlayer){
            Cruise();
        }
        if(ChasingPlayer&&(transform.position - playerPosition).sqrMagnitude <= 1.1){
            Debug.Log("Go Back Cruise"+playerPosition);
            ChasingPlayer = false;
            NMAgent.SetDestination(Origination);
            inOrigination = true;
        }
        
        if(Input.GetMouseButtonDown(0)){
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit RCHit;
            Physics.Raycast(ray, out RCHit);
            if(Physics.Raycast(ray, out RCHit)){
            }
        }
    }
    void SencorPlayer(){
        //getPosition
        PlayerSpot = GameEvents.current.playerSpot;
        playerPosition = PlayerSpot.position;
        ChasingPlayer = true;
        if(ChasingPlayer){
            Debug.Log("I Find You"+playerPosition);
        }
        NMAgent.SetDestination(playerPosition);
    }
    void Cruise(){
        Vector3 pos;
        if(!NMAgent.pathPending){
            if(NMAgent.velocity.sqrMagnitude==0){
            if(inOrigination && (transform.position - Origination).sqrMagnitude <= 0.1){
                NMAgent.SetDestination(Destination);
                inOrigination = false;
            }else if(!inOrigination && (transform.position - Destination).sqrMagnitude <=0.1){
                NMAgent.SetDestination(Origination);
                inOrigination = true;
            }
        }
        }
        
    }
    void onAlertMode(){
        SencorPlayer();
        sensorMaterial.SetColor("_Color", sensorAlertColor);
    }
    void offAlertMode(){

        sensorMaterial.SetColor("_Color", sensorColor);
    }
}
