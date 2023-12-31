using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject groundTile;
    Vector3 spawnPoint;

    public void SpawnTile(bool spawnings)
    {
        GameObject temp = Instantiate(groundTile, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
        if(spawnings){
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnObstacle2();
            temp.GetComponent<GroundTile>().SpawnCoins();
            //temp.GetComponent<GroundTile>().SpawnPowerup();
        }
    }

     public void SpawnTile2(bool spawnings2)
    {
        GameObject temp = Instantiate(groundTile, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
        if(spawnings2){
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnObstacle2();
            temp.GetComponent<GroundTile>().SpawnCoins();
            //temp.GetComponent<GroundTile>().SpawnPowerup();
        }
    }


    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            if(i<3){
                SpawnTile(false);
                
               
            } 
            else {
            SpawnTile(true);
            
            }
        }

        // if(GameScore.gscore.score==10){
        //     SpawnPower(true);
        // }
    }


    // void Update()
    // {
    //     if(GameScore.gscore.score%20==0){
    //         SpawnTile(true);
    //         SpawnPower(true);
    //     }
    // }

    // Update is called once per frame
    
}
