using UnityEngine;

public class MusicPlayerBackground : MonoBehaviour
{
    private static MusicPlayerBackground instance;
    public AudioSource backgroundMusic;

    void Awake()
    {
        backgroundMusic.Play();
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
