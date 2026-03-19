using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoal : MonoBehaviour
{
    private int score = 0;
    private float randomValue;
    public Object star;
    public Object floor;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnStar", 3.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnStar()
    {
        Vector3 randomPosition = transform.position + new Vector3(randomValue, 5.0f, 0.0f);
        Instantiate(star, randomPosition, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Collectible"))
        {
            //score += 1;
            AddScore();
            Debug.Log("Score: " + score);
            collision.gameObject.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            transform.position = new Vector3(0, 0, 0);
            score = 0;
            Debug.Log("Player has left the floor.");
        }
    }
    private void AddScore()
    {
        score += 20;
    }

    public int GetScore()
    {
        return score;
    }
}
