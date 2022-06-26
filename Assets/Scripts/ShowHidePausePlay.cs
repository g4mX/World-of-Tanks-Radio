using UnityEngine;

public class ShowHidePausePlay : MonoBehaviour
{
    public GameObject pause;
    public GameObject play;

    public void ShowPause() {
        pause.SetActive(true);
    }

    public void HidePause() {
        pause.SetActive(false);
    }

    public void ShowPlay() {
        play.SetActive(true);
    }

    public void HidePlay() {
        play.SetActive(false);
    }
}
