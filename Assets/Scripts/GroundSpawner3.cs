using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner3 : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 spawnPoint;

    public void SpawnTile(bool spawnings)
    {
        GameObject temp = Instantiate(groundTile, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
        if(spawnings){
            temp.GetComponent<GroundTile3>().SpawnObstacle();
            temp.GetComponent<GroundTile3>().SpawnObstacle2();
            temp.GetComponent<GroundTile3>().SpawnObstacle3();
            temp.GetComponent<GroundTile3>().SpawnCoins();
        }
    }

    public void SpawningTile(bool spawntiles)
    {
        GameObject temp = Instantiate(groundTile, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
        if(spawntiles){
            temp.GetComponent<GroundTile3>().SpawnObstacle();
            temp.GetComponent<GroundTile3>().SpawnCoins();
        }
    }

    public void SpawningTile2(bool spawntiles2)
    {
        GameObject temp = Instantiate(groundTile, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
        if(spawntiles2){
            temp.GetComponent<GroundTile3>().SpawnObstacle();
            //temp.GetComponent<GroundTile3>().SpawnObstacle2();
            temp.GetComponent<GroundTile3>().SpawnCoins();
        }
    }

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            if(i<2){
                SpawnTile(false);
                SpawningTile(false);
                SpawningTile2(false);
            } else {
            SpawnTile(true);
            SpawningTile(true);
            SpawningTile2(true);
            }
        }
    }
}
