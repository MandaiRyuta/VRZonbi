using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

using UnityEngine.SceneManagement;


public class TitleManager : MonoBehaviour
{
    private SteamVR_Action_Boolean actionToHaptic = SteamVR_Actions._default.InteractUI;

    public GameObject leftHand, RightHand;

    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SteamVR_Fade.Start(Color.white, 0.1f);
            SceneManager.LoadScene("ZonbiGame");
        }
        if (actionToHaptic.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            SteamVR_Fade.Start(Color.white, 0.1f);
            SceneManager.LoadScene("ZonbiGame");
        }

        if (actionToHaptic.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            SteamVR_Fade.Start(Color.white, 0.1f);
            SceneManager.LoadScene("ZonbiGame");
        }

        if (Input.GetKeyDown(KeyCode.A))
            {
                SteamVR_Fade.Start(Color.white, 0.1f);
                SceneManager.LoadScene("ZonbiGame");
            }
        
    }
}
