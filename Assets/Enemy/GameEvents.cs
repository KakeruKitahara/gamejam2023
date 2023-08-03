using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    public Transform playerSpot;
    private void Awake(){
        current = this;
    }
    public event Action onAlert;
    public void Alert(Transform spot){
        //Debug.Log(playerPosition);
        playerSpot = spot;
        if( onAlert != null){
            onAlert();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
