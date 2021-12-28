using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("BigObstacle") || other.gameObject.tag.Equals("Obstacle"))
        {
            FindObjectOfType<CharacterController2D>().OncollisionEnter2DChild();
        }
    }
}
