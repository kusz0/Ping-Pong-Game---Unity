using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;
    public AudioSource goalSound;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LeftRacet" || collision.gameObject.name == "RightRacet")
        {
            racketSound.Play();
        }
        else if (collision.gameObject.name == "LeftWall" || collision.gameObject.name == "RightWall")
        {
            goalSound.Play();
        }
        else
        {
            wallSound.Play();
        }
    
    }

}
