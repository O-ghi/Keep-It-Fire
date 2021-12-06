using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Obstacle"))
        {
            this.gameObject.transform.position += new Vector3(0.5f, 0f, 0f);
        }

        if (other.gameObject.tag.Equals("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}
