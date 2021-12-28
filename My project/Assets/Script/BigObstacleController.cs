using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigObstacleController : MonoBehaviour
{
    public float destroyTime;
    Transform randomPointPosition;
    bool removeWarningIcon = false;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject randomPoint = GameObject.Find("ObstaclePoint");
        randomPointPosition = randomPoint.transform;
        int increaseValue = randomPoint.GetComponent<RandomObstacleController>().getIncreaseValue();
        destroyTime += increaseValue;
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Ground"))
        {
            StartCoroutine(DestroyAfter(destroyTime));
        }

        // Collider2D myCollider2D = other.contacts[0].collider;
        // Debug.Log(myCollider2D);
    }

    IEnumerator DestroyAfter(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }

    public bool getRemoveWarningIcon()
    {
        return removeWarningIcon;
    }

    public void setRemoveWarningIcon(bool removeWarningIcon)
    {
        this.removeWarningIcon = removeWarningIcon;
    }
}
