using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    int myScore = 0;
    public TMP_Text finalScore;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = myScore.ToString();
        finalScore.text = "Score: " + myScore.ToString();
    }

    public void AddScore(int score)
    {
        myScore += score; 
    }
}
