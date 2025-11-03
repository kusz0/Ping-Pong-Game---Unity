using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public TextMeshProUGUI scoreTextPlayer1;
    public TextMeshProUGUI scoreTextPlayer2;


    public int goalToWin = 5;

  
    void Update()
    {
        if(scorePlayer1 >= goalToWin || scorePlayer2 >= goalToWin)
        {
            Debug.Log("End Game");
        }
    }

    private void FixedUpdate()
    {
        scoreTextPlayer1.text = scorePlayer1.ToString();

        scoreTextPlayer2.text = scorePlayer2.ToString();
    }
    public void GoalPlayer1()
    {
        scorePlayer1++;
    }
    public void GoalPlayer2()
    {
        scorePlayer2++;
    }


}
