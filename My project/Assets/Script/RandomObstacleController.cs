using UnityEngine.UI;
using UnityEngine;

public class RandomObstacleController : MonoBehaviour
{
    //public parameter 
    public GameObject obstacle;
    public GameObject bigObstacle;
    public int totalObstaclePerTurn = 10;

    //public value
    public float timeCouting = 1;

    //parameter
    GameObject scoreText;

    //value

    bool isCreated = false;
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {

        int score = int.Parse(scoreText.GetComponent<Text>().text);

        if (score % 2 == 0 && score > 0)
        {
            if (isCreated == false)
            {
                randomBigObstacle();
            }
            isCreated = true;
        }
        else
        {
            isCreated = false;
        }

        Debug.Log(isCreated);

        if (timeCouting <= 0)
        {
            for (int i = 0; i < totalObstaclePerTurn; i++)
            {
                randomObstacle();
            }
            timeCouting = 1;
        }

        timeCouting -= Time.deltaTime;

    }

    void randomObstacle()
    {
        float randomPositionX = Random.Range(-10f, 10f);
        float randomPositionY = Random.Range(this.transform.position.y, 20f);
        Instantiate(obstacle, new Vector3(randomPositionX, randomPositionY, 0), Quaternion.identity);
    }

    void randomBigObstacle()
    {
        float randomPositionX = Random.Range(-10f, 10f);
        Instantiate(bigObstacle, new Vector3(randomPositionX, this.transform.position.y + 5f), Quaternion.identity);
    }
}
