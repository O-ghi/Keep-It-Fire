using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    //Values
    [Range(1, 10)] [SerializeField] public float speed = 0.40f;


    //Import class
    private Rigidbody2D m_Rigidbody2D;
    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        var movement = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        transform.position += new Vector3(movement, 0, 0);

    }


}
