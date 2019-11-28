using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damege : MonoBehaviour
{
    public int damage;          //当たった部位毎のダメージ量

    private HP hp;              //HPクラス

    void Start()
    {

        hp = GetComponent<HP>();      //HP情報を取得
    }

    void OnTriggerEnter(Collider other)
    {
        //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        if (other.CompareTag("Bullet"))
        {
            //HPクラスのDamage関数を呼び出す
            hp.Damage(damage);

            //ぶつかってきたオブジェクトを破壊する.
            Destroy(other.gameObject);
        }
    }
}
