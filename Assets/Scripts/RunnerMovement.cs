using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunnerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    bool alive = true;
    public bool onground = true;
    public float speed = 5;
    public Rigidbody rb;
    float horizontalInput;
    float verticalInput;
    public float horizontalSpeed = 2;
    public float verticalSpeed = 4;
    public float speedIncrease = 0.1f;
    public float maxSpeed = 30;
    public float maxHeight = 5;

   
   

    void FixedUpdate(){

        if(!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalSpeed; 
        Vector3 verticalMove = transform.up * verticalInput * speed * Time.fixedDeltaTime * verticalSpeed;
        rb.MovePosition(rb.position + forwardMove + horizontalMove + verticalMove);
        
    }

    void Update()
    {
        positiontrans();
        
        
        if(transform.position.y < -5){
        Fall();
        }
        if(Input.GetButtonDown("Jump")){
            if (transform.position.y <= 1.05f){
            rb.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
            onground = false;}
        }
    }

    void positiontrans(){
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "GroundTile3"){
            onground = true;
        }
    }
        
    

    public void Die(){
        alive = false;
        //restart game
        Invoke("Restart", 1);
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    public void Fall(){
        alive = false;
        FindObjectOfType<AudioManager>().Play("Fall");
        //restart game
        Invoke("Restart", 0);
        
    }

    
}
