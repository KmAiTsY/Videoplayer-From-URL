using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject resume;
    public GameObject pause;
    public void Resume()
    {
        videoPlayer.Play();
        resume.SetActive(false);
        pause.SetActive(true);
    }
    public void Pause()
    {
        videoPlayer.Pause();
        pause.SetActive(false);
        resume.SetActive(true);
    }
}
