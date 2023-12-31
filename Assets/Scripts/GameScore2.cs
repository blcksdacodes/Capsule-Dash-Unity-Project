using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore2 : MonoBehaviour
{
    // Start is called before the first frame update
    int score2;
    public static GameScore2 gscore2;
    public Text scoreText2;
    public Text highScoreText2;
    public RunnerMovement runnerMovement;

    public void IncrementScore(){
        score2++;
        scoreText2.text = "VIRUS ELIMINATED: " + score2.ToString();
        runnerMovement.speed += runnerMovement.speedIncrease;
        if(score2 > PlayerPrefs.GetInt("HighScore2",0)){
             PlayerPrefs.SetInt("HighScore2", score2);
             highScoreText2.text ="HIGHEST: "+score2.ToString();
        }
        
       

    }

    public void highscore(){
        // PlayerPrefs.SetInt("HighScore", score);
    }
    private void Awake()
    {
        gscore2 = this;
    }

    void Start()
    {
        highScoreText2.text = "HIGHEST: " + PlayerPrefs.GetInt("HighScore2", 0).ToString();
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
