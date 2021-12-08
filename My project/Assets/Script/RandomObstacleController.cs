using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacleController : MonoBehaviour
{
    //parameter
    public GameObject obstacle;
    public int totalObstaclePerTurn = 10;

    //value
    public float timeCouting = 1;
    // Update is called once per frame
    void Update()
    {

        if (timeCouting <= 0)
        {
            for (int i = 0; i < totalObstaclePerTurn; i++)
            {
                randomObstacle();
            }
            timeCouting = 1;
        }

        timeCouting -= Time.deltaTime;
        Debug.Log(timeCouting);



    }

    void randomObstacle()
    {
        float randomPositionX = Random.Range(-10f, 10f);
        float randomPositionY = Random.Range(this.transform.position.y, 20f);
        Instantiate(obstacle, new Vector3(randomPositionX, randomPositionY, 0), Quaternion.identity);
    }
}
