using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detact : MonoBehaviour
{
    private GunLight gunLight;
    private Gun gun;
    private void Update()
    {
        gunLight= GameObject.Find("Gun Light").GetComponent<GunLight>();
        gun = GameObject.Find("Gun").GetComponent<Gun>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gunLight.isClose = true;
            gun.FireBullet();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gunLight.isClose = false;
        }
    }
}
