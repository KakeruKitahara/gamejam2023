using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBgmSpeed : MonoBehaviour
{
    [SerializeField] private Transform playerTransform; // プレイヤーオブジェクトのTransform
    [SerializeField] private AudioSource bgmAudioSource; // BGMのAudioSource
    [SerializeField] private float maxDistance = 10f; // 最大の距離（BGMの再生速度が最速になる距離）
    [SerializeField] private float minSpeedMultiplier = 0.5f; // 最低再生速度の倍率

    private void Update()
    {
        // プレイヤーとこのオブジェクトの距離を計算
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);

        // プレイヤーとオブジェクトの距離に応じてBGMの再生速度を調整する
        float speedMultiplier = Mathf.Lerp(1.0f, minSpeedMultiplier, distanceToPlayer / maxDistance);
        bgmAudioSource.pitch = Mathf.Max(speedMultiplier, 1.0f);
    }
}