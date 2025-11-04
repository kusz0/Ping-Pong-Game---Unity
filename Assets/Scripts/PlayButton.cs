using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayVsAI()
    {
        Debug.Log("Play vs AI was pressed");
        GameMode.IsAI = true;
        SceneManager.LoadScene("GameScene");
    }

    public void Play1v1()
    {
        Debug.Log("Play 1v1 was pressed");
        GameMode.IsAI = false;
        SceneManager.LoadScene("GameScene");
    }
}
