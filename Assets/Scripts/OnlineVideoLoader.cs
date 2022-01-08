using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class OnlineVideoLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public InputField inputField;
    public GameObject resume;
    public GameObject pause;

    IEnumerator TestCoroutine()
    {
        videoPlayer.Prepare();
        while (!videoPlayer.isPrepared)
        {
            yield return new WaitForEndOfFrame();
        }

        videoPlayer.Play();
    }
    public void SubmitAndStart()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        resume.SetActive(false);
        pause.SetActive(true);
        videoPlayer.playOnAwake = true;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.Direct;
        string videoUrl = inputField.text;
        videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.controlledAudioTrackCount = 1;
        videoPlayer.EnableAudioTrack(0, true);
        StartCoroutine(TestCoroutine());
    }
}