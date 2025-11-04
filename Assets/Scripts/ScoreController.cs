using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public TextMeshProUGUI scoreTextPlayer1;
    public TextMeshProUGUI scoreTextPlayer2;

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public int goalToWin = 5;

  
    void Update()
    {
        NewScore();
        
        if(scorePlayer1 >= goalToWin || scorePlayer2 >= goalToWin)
        {
            Debug.Log("End Game");
            SceneManager.LoadScene("GameOver");            
        }
    }

    private void NewScore()
    {
        scoreTextPlayer1.text = scorePlayer1.ToString() ;

        scoreTextPlayer2.text = scorePlayer2.ToString();
    }
    public void GoalPlayer1()
    {
        scorePlayer1++;
        Debug.Log($"player1 scored {scorePlayer1}");
    }
    public void GoalPlayer2()
    {
        scorePlayer2++;
        Debug.Log($"player2 scored {scorePlayer2}");
    }


}
