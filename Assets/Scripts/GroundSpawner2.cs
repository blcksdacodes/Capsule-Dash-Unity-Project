using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject groundTile;
    Vector3 spawnPoint;

    public void SpawnTile(bool spawnings)
    {
        GameObject temp = Instantiate(groundTile, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
        if(spawnings){
            temp.GetComponent<GroundTile2>().SpawnObstacle();
            temp.GetComponent<GroundTile2>().SpawnCoins();
        }
    }

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            if(i<5){
                SpawnTile(false);
            } else {
            SpawnTile(true);
            }
        }
    }

    // Update is called once per frame
    
}

