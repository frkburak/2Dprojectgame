using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed;
    private Rigidbody2D rb;
    private PlayerHealth playerHealth;
    private Delay delay;
    [SerializeField] ParticleSystem hitParticle;
    [SerializeField] ParticleSystem PlayerDeathParticle;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerHealth = GameObject.Find("Level Manager").GetComponent<PlayerHealth>();
        delay = GameObject.Find("Level Manager").GetComponent<Delay>();
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.velocity = -transform.right * bulletSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(PlayerDeathParticle, transform.position, Quaternion.identity);

            collision.gameObject.SetActive(false);
            playerHealth.Lives();                   
            delay.DelayNewTime();
        }
        if(collision.gameObject.CompareTag("Zemin"))
        {
            Instantiate(hitParticle, transform.position, Quaternion.identity);
        }
       
    }
}
