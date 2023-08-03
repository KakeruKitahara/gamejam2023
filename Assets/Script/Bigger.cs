using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発射したオブジェクトを大きくするスクリプト
public class Bigger: MonoBehaviour
{
    //大きさの変化量
    public float scale = 0.01f;
    //大きさ
    public float sx;
    public float sy;
    public float sz;

    private void Start()
    {
        sx = transform.localScale.x;
        sy = transform.localScale.y;
        sz = transform.localScale.z;
    }

    private void Update()
    {
        
        Vector3 s = new Vector3(sx, sy, sz);
        sx += scale;
        sz += scale;
        transform.localScale = s;
    }
}
