using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PointManager : MonoBehaviour
{

    public int score;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateScore(int points){
        score += points;
        scoreText.text = "Pontos: " + score; 
        if(score == 1050){
            SceneManager.LoadScene("Slide8");
        }

        
    }
}
