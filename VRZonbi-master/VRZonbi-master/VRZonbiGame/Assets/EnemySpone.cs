using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpone : MonoBehaviour
{
    [SerializeField]
    private GameObject zonbi;
    [SerializeField]
    private float AddRangetime;
    private float sponetime;
    private float startrenge, endrenge;
    private float starttime, endtime;
    void Stat()
    {
        sponetime = 0.0f;
        starttime = 20;
        endtime = 60;
    }

    void Update()
    {
        tsuimiki();
    }

    void tsuimiki()
    {
        sponetime += Time.deltaTime;
        startrenge = starttime + AddRangetime;
        endrenge = endtime + AddRangetime;
        float spone = Random.Range(startrenge,endrenge);
        if(sponetime > spone)
        {
            if (GameManager.Instance.GetZonbiNumLimit() > GameManager.Instance.GetZonbiNum())
            {
                if(starttime >= 5.0f)
                {
                    starttime = starttime - (AddRangetime - AddRangetime * 0.8f);
                }
                if(endtime >= 10.0f)
                {
                    endtime = endtime - (AddRangetime - AddRangetime * 0.8f);
                }
                //生成処理
                zonbi = Instantiate(zonbi, transform.position, Quaternion.identity);
                sponetime = 0;
                GameManager.Instance.AddZonbiNum();
            }
        }
    }
}
