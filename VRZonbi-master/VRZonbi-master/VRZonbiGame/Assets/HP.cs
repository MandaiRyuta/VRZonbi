using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hitPoint = 100;  //HP
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

        //HPが0になったときに敵を破壊する
        if (hitPoint <= 0)
        {
            animator.SetBool("death", true);
            Destroy(gameObject,5f);
            hitPoint = 1000;
        }

    }

    //ダメージを受け取ってHPを減らす関数
    public void Damage(int damage)
    {
        animator.SetBool("damage", true);
        //受け取ったダメージ分HPを減らす
        hitPoint -= damage;
    }
}
