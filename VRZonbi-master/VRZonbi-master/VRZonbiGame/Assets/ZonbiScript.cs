using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonbiScript : MonoBehaviour
{
    [SerializeField]
    Transform player;

    UnityEngine.AI.NavMeshAgent nav;
    private Animator animator;

    void Awake()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("speed", 1.0f);
        nav.SetDestination(player.position);
    }

    void OnTriggerEnter(Collider other)
    {
        //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        if (other.tag == "Player")
        {
            animator.SetBool("attack", true);
        }
    }
}
