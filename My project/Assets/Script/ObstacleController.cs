using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    Transform randomPointPosition;
    bool isCollision = false;

    private void Start()
    {
        GameObject randomPoint = GameObject.Find("ObstaclePoint");
        randomPointPosition = randomPoint.transform;
        Debug.Log(randomPointPosition);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Obstacle") && isCollision == false && this.gameObject.transform.position.y > randomPointPosition.position.y)
        {
            this.gameObject.transform.position += new Vector3(0.5f, 0f, 0f);
            isCollision = true;
        }

        if (other.gameObject.tag.Equals("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}
