using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource backgroundMusic;
    public AudioClip mainTrack;
    public AudioClip goodEndingTrack;
    public AudioClip badEndingTrack;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        PlayMainTrack();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log(scene.name);
        if (scene.name == "Main")
        {
            if (!IsPlaying(mainTrack))
                PlayMainTrack();
        }
        else if (scene.name == "yay" || scene.name == "PostShiftLike" || scene.name == "TEDwins" || scene.name == "PostShiftReject")
        {
            if (!IsPlaying(goodEndingTrack))
                PlayGoodEndingTrack();
        }
        else if (scene.name == "WompWomp" || scene.name == "TedDead" || scene.name == "Rejected")
        {
            if (!IsPlaying(badEndingTrack))
                PlayBadEndingTrack();
        }
        else if (scene.name == "TedDead")
        {
            if (!IsPlaying(badEndingTrack))
                PlayBadEndingTrack();
        }
        else
        {
            if (!IsPlaying(mainTrack))
                PlayMainTrack();
        }
    }

    void PlayMainTrack()
    {
        if (!backgroundMusic.enabled)
            backgroundMusic.enabled = true;

        backgroundMusic.clip = mainTrack;
        backgroundMusic.Play();
    }

    void PlayGoodEndingTrack()
    {
        if (!backgroundMusic.enabled)
            backgroundMusic.enabled = true;

        backgroundMusic.clip = goodEndingTrack;
        backgroundMusic.Play();
    }

    void PlayBadEndingTrack()
    {
        if (!backgroundMusic.enabled)
            backgroundMusic.enabled = true;

        backgroundMusic.clip = badEndingTrack;
        backgroundMusic.Play();
    }

    bool IsPlaying(AudioClip clip)
    {
        return backgroundMusic.isPlaying && backgroundMusic.clip == clip;
    }
}
