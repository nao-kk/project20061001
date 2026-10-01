using UnityEngine;
using UnityEngine.AI; // NavMeshを使うために必須！

public class EnemyChaser : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform playerTransform;

    void Start()
    {
        // 自身のアタッチされているNavMeshAgentを取得
        agent = GetComponent<NavMeshAgent>();

        // "Player"タグがついたオブジェクトを探してその位置情報を取得
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            playerTransform = player.transform;
        }
    }

    void Update()
    {
        // プレイヤーが存在する場合、常にその座標を目的地（destination）に設定する
        if (playerTransform != null)
        {
            agent.destination = playerTransform.position;
        }
    }
}
