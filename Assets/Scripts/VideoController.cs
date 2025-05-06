using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = image.GetComponent<VideoPlayer>();
        videoPlayer.Play();
        videoPlayer.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartVideo()
    {
        videoPlayer.Play();
    }
}
