using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SimpleShoot : MonoBehaviour
{
    /// <summary>
    /// コントローラの設定
    /// </summary>
    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean GrabAction;

    public GameObject bulletPrefab;
    public GameObject casingPrefab;
    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    public Transform casingExitLocation;


    public float shotPower = 500f;

    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;
    }

    void Update()
    {
        //if (GrabAction.GetState(SteamVR_Input_Sources.RightHand))
        //{
        //    GetComponent<Animator>().SetTrigger("Fire");
        //}

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("Fire");
        }
    }

    void Shoot()
    {
        GameObject bullet;
        bullet = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);

        GameObject tempFlash;
        //Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
        tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
        
        Destroy(tempFlash, 3.0f);
        Destroy(bullet, 3.0f);
        //  Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation).GetComponent<Rigidbody>().AddForce(casingExitLocation.right * 100f);
       
    }

    void CasingRelease()
    {
        GameObject casing;
        casing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
        casing.GetComponent<Rigidbody>().AddExplosionForce(550f, (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        casing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(10f, 1000f)), ForceMode.Impulse);

        Destroy(casing, 1.5f);
    }

}
