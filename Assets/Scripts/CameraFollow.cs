using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform runner;
    Vector3 offset;


    void Start()
    {
        offset = transform.position - runner.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos =transform.position = runner.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
