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

        // 1�t���[�����Ƃɏ������s��
        MAXCNT = 1;

        // �|�[���̐�
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
            // �|�[��i�ƃv���C���[�̈ʒu
            pollPoses = new Vector3[pollnum];
            for (int i = 0; i < pollnum; i++)
            {
                Vector3 pollPos = poll[i].transform.position;
                pollPoses[i] = pollPos;
            }
            Vector3 playerPos = player.transform.position;

            // �|�[��i�ƃv���C���[�i�ԁj�̋���
            dists = new float[pollnum];
            for (int i = 0; i < pollnum; i++)
            {
                float dist = Vector3.Distance(pollPoses[i], playerPos);
                dists[i] = dist;
            }


            if (dists.Min() < 15.0f)
            {
                // �o�[�ɋ߂Â�����Đ����x��������i�ő�2�{�j
                // audioSource.pitch = 2 - dist/15.0f;

                // �o�[�ɋ߂Â�����Đ����x��2�{�ɂ���
                audioSource.pitch = 2;
            }
            else
            {
                // �����łȂ����1�{
                audioSource.pitch = 1;
            }
        }
    }
}