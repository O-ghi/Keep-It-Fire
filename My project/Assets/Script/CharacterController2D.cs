using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{

    public void OncollisionEnter2DChild()
    {
        FindObjectOfType<GameController>().GameOver();
    }
}
