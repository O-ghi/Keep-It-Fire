using UnityEngine.UI;
using UnityEngine;


public class RandomObstacleController : MonoBehaviour
{
    //public parameter 
    public GameObject obstacle;
    public GameObject bigObstacle;
    public GameObject warningIcon;

    //public value
    public float timeCouting = 1f;
    public int scoreToAppear = 10;
    public int scoreToInscrease = 20;
    public int totalObstaclePerTurn = 10;

    //parameter
    GameObject scoreText;
    GameObject player;
    //value

    bool isCreated = false;
    bool isIncreased = false;
    int increaseValue = 0;


    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        int score = int.Parse(scoreText.GetComponent<Text>().text);

        if (score % scoreToAppear == 0 && score > 0)
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

        if (timeCouting <= 0)
        {
            for (int i = 0; i < totalObstaclePerTurn; i++)
            {
                randomObstacle();
            }
            timeCouting = 1;
        }

        //Increase total Obstacle time by time
        if (score % scoreToInscrease == 0 && score > 0)
        {
            if (isIncreased == false)
            {
                timeCouting -= 0.1f;
                totalObstaclePerTurn += 1;
                if (score % 25 == 0 && scoreToAppear >= 5)
                {
                    scoreToAppear -= 1;
                    increaseValue++;
                }
            }
            isIncreased = true;
        }
        else
        {
            isIncreased = false;
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
        float randomPositionX = Random.Range(player.transform.position.x + 3f, player.transform.position.x - 3f);
        Instantiate(bigObstacle, new Vector3(randomPositionX, this.transform.position.y + 10f, -1f), Quaternion.identity);
        Instantiate(warningIcon, new Vector3(randomPositionX, 4.4f, -1f), Quaternion.identity);
    }

    public int getIncreaseValue()
    {
        return this.increaseValue;
    }
}
