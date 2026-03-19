using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{

    public Text scoreText;
    public GameObject player; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerGoal playerGoal = player.GetComponent<PlayerGoal>();
        int score = playerGoal.GetTotalScore();

        if (scoreText != null)
        {
            scoreText.text = "Score : " + score;
        }
    }
}
