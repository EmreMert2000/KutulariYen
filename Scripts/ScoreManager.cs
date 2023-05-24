using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoretext, speedtext;
    public OnCollison score;
    public PlayerMovement playerMovement;
    private void Start()
    {
        scoretext.text = "SCORE:0";
        
        
    }
    private void Update()
    {
        scoretext.text = "SCORE:" + score.score;
        speedtext.text = "SPEED:" + playerMovement.forwardForce;
    }
   

}
