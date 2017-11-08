using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour
{
    //[SerializeField]
    //RawImage image;
    //[SerializeField]
    //VideoClip clip;

    [SerializeField]
    VideoPlayer vPlayer;
    //VideoSource vSource;
    AudioSource aSource;

	// Use this for initialization
	void Start ()
    {
        //vPlayer = GetComponent<VideoPlayer>();
        //aSource = GetComponent<AudioSource>();

        //Debug.Log("start");
	}
	
	// Update is called once per frame
	//void Update ()
 //   {
		
	//}

    public void StartOrStopVideo()
    {
        //Debug.Log("here");
        if (vPlayer.isPlaying)
        {
            vPlayer.Pause();
        }
        else
        {
            vPlayer.Play();
        }
    }
}
