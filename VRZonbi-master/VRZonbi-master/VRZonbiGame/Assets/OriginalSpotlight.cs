using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class OriginalSpotlight : MonoBehaviour
{
    /// <summary>
    /// コントローラの設定
    /// </summary>
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean GrabAction;

    [SerializeField]
    Light spotlight;
    bool flag;
    [SerializeField]
    private float power;
    // Start is called before the first frame update
    void Start()
    {
        spotlight.intensity = 0;
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GrabAction.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            flag = true;
        }
        else if(GrabAction.GetStateUp(SteamVR_Input_Sources.LeftHand))
        {
            flag = false;
        }

        if(flag)
        {
            if(spotlight.intensity <= power)
            {
                spotlight.intensity += 0.5f;
            }
        }
        else if(!flag)
        {
            if (spotlight.intensity >= 0)
            {
                spotlight.intensity -= 0.5f;
            }
        }
    }
}
