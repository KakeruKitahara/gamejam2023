using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameScene : MonoBehaviour
{
    GameObject player;
    GameObject stage;
    GameObject enemy;
    GameObject goal;
    string playerPath ="SM_Veh_Car_Small_01";
    string stagePath = "";
    string enemyPath = "SM_Veh_Car_Police_01";
    string goalPath = "SM_Prop_Sign_Pizza_01";
    string checkpointPath = "SM_Icon_Letter_Money_01";
    // Start is called before the first frame update
    void Awake()
    {
        player = Resources.Load<GameObject>(playerPath);
        if(player != null ) {
            Instantiate(player, Vector3.zero+new Vector3(0,10,0), Quaternion.identity);
        }
        //cameraê›íË
        if (player == null)
        {
            transform.SetParent(player.transform, false);
            transform.localPosition = new Vector3(0, 0, -5.0f);
        }
        //objectê∂ê¨
        stage = Resources.Load<GameObject>(stagePath);
        if (stage != null)
        {
            Instantiate(player, Vector3.zero, Quaternion.identity);
        }
        enemy = Resources.Load<GameObject>(enemyPath);
        if (enemy != null)
        {
            Instantiate(player, Vector3.zero, Quaternion.identity);
        }
        goal = Resources.Load<GameObject>(goalPath);
        if (player != null)
        {
            Instantiate(goal, Vector3.zero, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
