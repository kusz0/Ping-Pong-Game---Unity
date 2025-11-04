using UnityEngine;

public class RacetModeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameMode.IsAI)
        {
            GetComponent<AiMovement>().enabled = true;
            GetComponent<RacetPlayer2>().enabled = false;
        }
        else
        {
            GetComponent<AiMovement>().enabled = false;
            GetComponent<RacetPlayer2>().enabled = true;
        }
    }

}
