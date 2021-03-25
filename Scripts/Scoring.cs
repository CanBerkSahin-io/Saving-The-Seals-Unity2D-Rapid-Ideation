using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public GameObject scoreTextEndLevel;
    
    void Start()
    {
        theScore = 0;
        
    }
     
    void Update()
    {
            
            scoreText.GetComponent<Text>().text = "SEALS SAVED: " + theScore;
            scoreTextEndLevel.GetComponent<Text>().text = "SEALS SAVED: " + theScore;

        if (theScore <=0)
        {
            theScore = 0;
        }

    }

}
