using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameScene : MonoBehaviour
{
    GameObject player;
    GameObject enemy;
    GameObject goal;
    string playerPath ="SM_Veh_Car_Small_01";
    string enemyPath = "SM_Veh_Car_Police_01";
    string goalPath = "SM_Prop_Sign_Pizza_01";
    string checkpointPath = "SM_Icon_Letter_Money_01";
    // Start is called before the first frame update
    void Awake()
    {
        player = Resources.Load<GameObject>(playerPath);
        enemy= Resources.Load<GameObject>(enemyPath);
        if (player != null ) {
            Instantiate(player, Vector3.zero, Quaternion.identity);
        }
        //camera�ݒ�
        if (player == null)
        {
            transform.SetParent(player.transform, false);
            transform.localPosition = new Vector3(0, 0, -5.0f);
        }
        //object����
        enemy = Resources.Load<GameObject>(enemyPath);
        if (enemy != null)
        {
            Instantiate(enemy, Vector3.zero + new Vector3(0,0,10), Quaternion.identity);
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
