using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fries : MonoBehaviour
{
    private Delay delay;
    private LevelManager levelManager;
    [SerializeField] int friesValue;
    
    void Start()
    {
        delay = GameObject.Find("Level Manager").GetComponent<Delay>();
        levelManager = GameObject.Find("Level Manager").GetComponent<LevelManager>();
        friesValue= Random.Range(1,10);
    }   
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager.instance.AddPoint(friesValue);
            Destroy(gameObject);
            delay.FriesNewTime();
            levelManager.count++;

        }
    }
}
