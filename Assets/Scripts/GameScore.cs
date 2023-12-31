using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public int score;
    int scores2;
    int scores3;
    int power;
    public static GameScore gscore;
    public Text scoreText;
    public Text highScoreText;
    public Text scoreText2;
    public Text highScoreText2;
    public Text scoreText3;
    public Text highScoreText3;
    public RunnerMovement runnerMovement;

    public void IncrementScore(){
        score++;
        scoreText.text = "VIRUS ELIMINATED: " + score.ToString();
        //scoreText2.text = "VIRUS ELIMINATED: " + score.ToString();
        runnerMovement.speed += runnerMovement.speedIncrease;
        if(score > PlayerPrefs.GetInt("HighScore",0)){
             PlayerPrefs.SetInt("HighScore", score);
             highScoreText.text ="HIGHEST: "+score.ToString();
        }
       

    }

    public void IncrementScore2(){
        scores2++;
        scoreText2.text = "VIRUS ELIMINATED: " + scores2.ToString();
        //scoreText2.text = "VIRUS ELIMINATED: " + score.ToString();
        runnerMovement.speed += runnerMovement.speedIncrease;
        if(scores2 > PlayerPrefs.GetInt("HighScore2",0)){
             PlayerPrefs.SetInt("HighScore2", scores2);
             highScoreText2.text ="HIGHEST: "+scores2.ToString();
        }
       

    }

     public void IncrementScore3(){
        scores3++;
        scoreText3.text = "VIRUS ELIMINATED: " + scores3.ToString();
        //scoreText2.text = "VIRUS ELIMINATED: " + score.ToString();
        runnerMovement.speed += runnerMovement.speedIncrease;
        if(scores3 > PlayerPrefs.GetInt("HighScoree3",0)){
             PlayerPrefs.SetInt("HighScoree3", scores3);
             highScoreText2.text ="HIGHEST: "+scores3.ToString();
        }
       

    }

    public void powerup(){
        if(score == 10){
            power++;
        }
    }

   

    public void highscore(){
        // PlayerPrefs.SetInt("HighScore", score);
    }
    private void Awake()
    {
        gscore = this;
    }

    void Start()
    {
        highScoreText.text = "HIGHEST: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        highScoreText2.text = "HIGHEST: " + PlayerPrefs.GetInt("HighScore2", 0).ToString();
        highScoreText3.text = "HIGHEST: " + PlayerPrefs.GetInt("HighScoree3", 0).ToString();
    }

//    public void Reset(){
//         PlayerPrefs.DeleteKey("HighScore");
//         highScoreText.text = "0";
//     }


    // Update is called once per frame
    void Update()
    {
        
    }
}
