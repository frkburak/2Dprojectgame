using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform playerSpawnPos;
    [SerializeField] GameObject friesPrefab;
    [SerializeField] Transform friesSpawnPos;
    public int count;
    [SerializeField] GameObject door;
    [SerializeField] GameObject runText;
    public static bool canMove;
   
    private void Awake()
    {
        PlayerSpawner();
        FriesSPawner();

    }
    void Start()
    {
        
    }
    private void Update()
    {
        if (count==5)
        {
          door.SetActive(true);
            runText.SetActive(true);
        }
    }


    void PlayerSpawner()
    {
        Instantiate(playerPrefab, playerSpawnPos.transform.position, playerPrefab.transform.rotation);

    }
    private void FriesSPawner()
    {
        Instantiate(friesPrefab, friesPos(), Quaternion.identity);
    }

    public void PlayerRespawner()
    {
        Instantiate(playerPrefab, playerSpawnPos.transform.position, playerPrefab.transform.rotation);
    }
    public void FriesRespawner()
    {
        Instantiate(friesPrefab, friesPos(), Quaternion.identity/*transform.rotation*/);
    }
    
    private Vector3 friesPos()
    {
        float friesPosX = Random.Range(-17, 17);
        float friesPosY = Random.Range(-10, -6);
        Vector3 spawnPos = new Vector3(friesPosX, friesPosY, 0f);
            return spawnPos;
    }
    private IEnumerator DelayNewTime()
    {
        yield return new WaitForSeconds(1f);
        PlayerRespawner();
    }

}
