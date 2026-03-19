using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayScore : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public GameObject johnny;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerGoal playerGoal = johnny.GetComponent<PlayerGoal>();
        int score = playerGoal.GetScore();
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }

    }
}
