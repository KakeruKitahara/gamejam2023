using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPitch : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    int cnt;
    int MAXCNT;

    int pollnum;

    [SerializeField] private GameObject[] poll;
    [SerializeField] private GameObject player;

    Vector3[] pollPoses;
    float[] dists;

    // Start is called before the first frame update
    void Start()
    {
        cnt = 0;

        // 1フレームごとに処理を行う
        MAXCNT = 1;

        // ポールの数
        pollnum = 28;
        player = GameObject.Find("SM_Veh_Car_Small_01(Clone)");
    }

    // Update is called once per frame
    void Update()
    {
        cnt++;
        cnt %= MAXCNT;

        if (cnt == 0)
        {
            // ポールiとプレイヤーの位置
            pollPoses = new Vector3[pollnum];
            for (int i = 0; i < pollnum; i++)
            {
                Vector3 pollPos = poll[i].transform.position;
                pollPoses[i] = pollPos;
            }
            Vector3 playerPos = player.transform.position;

            // ポールiとプレイヤー（車）の距離
            dists = new float[pollnum];
            for (int i = 0; i < pollnum; i++)
            {
                float dist = Vector3.Distance(pollPoses[i], playerPos);
                dists[i] = dist;
            }


            if (dists.Min() < 15.0f)
            {
                // バーに近づいたら再生速度をあげる（最大2倍）
                // audioSource.pitch = 2 - dist/15.0f;

                // バーに近づいたら再生速度を2倍にする
                audioSource.pitch = 2;
            }
            else
            {
                // そうでなければ1倍
                audioSource.pitch = 1;
            }
        }
    }
}