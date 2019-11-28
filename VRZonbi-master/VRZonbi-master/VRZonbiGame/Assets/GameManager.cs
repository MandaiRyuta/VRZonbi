using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    private int ZonbiNum;
    [SerializeField]
    private int ZonbiNumLimit;
    private void Start()
    {
        ZonbiNum = 0;
    }
    public int GetZonbiNum()
    {
        return ZonbiNum;
    }

    public void SetZonbiNum(int nowNum)
    {
        ZonbiNum = nowNum;
    }

    public void AddZonbiNum()
    {
        ZonbiNum = ZonbiNum + 1;
    }
    public void DeathZonbi()
    {
        ZonbiNum = ZonbiNum - 1;
    }

    public int GetZonbiNumLimit()
    {
        return ZonbiNumLimit;
    }
}
