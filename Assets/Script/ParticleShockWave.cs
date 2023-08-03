using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//パーティクルを発生させるオブジェクトに付ける
public class ParticleShockWave : MonoBehaviour
{
    public GameObject particleObject;
    private void OnCollisionEnter(Collision collision)
    {  
        if (collision.gameObject.tag == "Object") //Objectタグの付いたゲームオブジェクトと衝突したか判別
        {
            Instantiate(particleObject, this.transform); //パーティクル用ゲームオブジェクト生成
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
