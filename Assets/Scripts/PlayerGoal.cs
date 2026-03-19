using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerGoal : MonoBehaviour
{
    public Object star;
    // public GameObject floor;
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnStar", 3.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnStar()
    {
        Vector3 randomPosition = transform.position + new Vector3(Random.Range(-5f, 5f), 5.0f, 0);
        Instantiate(star, randomPosition, Quaternion.identity);
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Collectible")
        {
            AddScore();
            // Destroy(other.gameObject);
            other.gameObject.SetActive(false);

        }

         if (other.gameObject.tag == "Floor")
        {
            SceneManager.LoadScene("SampleScene");
        }
    
    }
    void AddScore()
    {
        score += 20;
    }

    public int GetTotalScore()
    {
        return score;
    }


       
}
