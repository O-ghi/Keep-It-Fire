using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Text scoreText;
    private float time;
    private int score;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 1f)
        {
            score += 1;
            scoreText.text = score.ToString();
            time = 0;
        }


    }
}
