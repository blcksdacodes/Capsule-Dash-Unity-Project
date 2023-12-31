using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float turnSpeed = 90f;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Obstacle>() != null){
            Destroy(gameObject);
        }

        if(other.gameObject.name != "Runner"){
            return;
        }

        FindObjectOfType<AudioManager>().Play("CoinsSound");

        //Add to Score
        //GameScore.gscore.IncrementScore();
        GameScore.gscore.IncrementScore2();
        //GameScore2.gscore2.IncrementScore();
        //GameScore.gscore.IncrementScore3();

        //Destroy Coin
         Destroy(gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 ,0, turnSpeed * Time.deltaTime);
    }
}
