using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update

    RunnerMovement runnerMovement;

    void Start()
    {
        runnerMovement = GameObject.FindObjectOfType<RunnerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Kill Runner
        if(collision.gameObject.name == "Runner"){
            FindObjectOfType<AudioManager>().Play("Death");
            runnerMovement.Die();
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
