using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Vector3 direction;
    private Vector2 target;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawnPos;
    [SerializeField] float fireRate;
    [SerializeField] ParticleSystem hitParticle;
    private float nextFire = 0;
   
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(player != null) 
        {
        target = player.transform.position;
            direction = target -(Vector2)transform.position;
        transform.right = -direction;
        } 
    }
    public void FireBullet()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time+fireRate;
            Fire();
        }
    }

    public void Fire()
    {
        Instantiate(bulletPrefab, bulletSpawnPos.transform.position, bulletSpawnPos.transform.rotation);
        Instantiate(hitParticle, bulletSpawnPos.transform.position, Quaternion.identity);
    }
}
