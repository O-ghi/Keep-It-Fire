using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningIconController : MonoBehaviour
{
    GameObject bigObstacle;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("BigObstacle"))
        {
            Destroy(this.gameObject);
        }
    }
}
