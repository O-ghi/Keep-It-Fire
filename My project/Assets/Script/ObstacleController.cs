using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    //public parameter
    public float destroyTime = 1f;
    Transform randomPointPosition;
    bool isCollision = false;
    private void Start()
    {
        GameObject randomPoint = GameObject.Find("ObstaclePoint");
        randomPointPosition = randomPoint.transform;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Obstacle") && isCollision == false && this.gameObject.transform.position.y > randomPointPosition.position.y)
        {
            this.gameObject.transform.position += new Vector3(0.5f, 0f, 0f); //Obstacle will push the other if they touch each other
            isCollision = true;
        }

        if (other.gameObject.tag.Equals("Ground"))
        {
            if (this.gameObject.tag.Equals("BigObstacle")) //BigObstacle will coutdown to destroy
            {
                StartCoroutine(DestroyAfter(destroyTime));
            }
            else
            {
                Destroy(this.gameObject);
            }

        }
    }

    IEnumerator DestroyAfter(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Destroy");
        Destroy(this.gameObject);
    }
}
