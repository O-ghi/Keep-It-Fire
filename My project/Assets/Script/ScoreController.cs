using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{

    public Text scoreText;

    //private value
    private float time;
    private int score;

    //Object
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 1f && cam.GetComponent<GameController>().getGameHasEnded() == false)
        {
            score += 1;
            scoreText.text = score.ToString();
            time = 0;
        }


    }
}
