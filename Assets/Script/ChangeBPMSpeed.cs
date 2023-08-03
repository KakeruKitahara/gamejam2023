using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBgmSpeed : MonoBehaviour
{
    [SerializeField] private Transform playerTransform; // �v���C���[�I�u�W�F�N�g��Transform
    [SerializeField] private AudioSource bgmAudioSource; // BGM��AudioSource
    [SerializeField] private float maxDistance = 10f; // �ő�̋����iBGM�̍Đ����x���ő��ɂȂ鋗���j
    [SerializeField] private float minSpeedMultiplier = 0.5f; // �Œ�Đ����x�̔{��

    private void Update()
    {
        // �v���C���[�Ƃ��̃I�u�W�F�N�g�̋������v�Z
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // �v���C���[�ƃI�u�W�F�N�g�̋����ɉ�����BGM�̍Đ����x�𒲐�����
        float speedMultiplier = Mathf.Lerp(1.0f, minSpeedMultiplier, distanceToPlayer / maxDistance);
        bgmAudioSource.pitch = Mathf.Max(speedMultiplier, 1.0f);
    }
}