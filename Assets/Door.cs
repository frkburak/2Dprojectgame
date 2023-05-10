using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    
    void Start()
    {
        SoundManager.Instance.DoorSound();
    }
    

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winPanel.SetActive(true);
        SoundManager.Instance.WinSound();
    }
}
