using UnityEngine;
using UnityEngine.UI;

public class PlaySoundtrack : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] soundtracks;
    public Text songNameText;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start() {
        audioSource.clip = soundtracks[Random.Range(0, soundtracks.Length)];
        audioSource.Play();
        songNameText.text = audioSource.clip.name.ToString();
        Invoke(nameof(Start), audioSource.clip.length);
    }
}
