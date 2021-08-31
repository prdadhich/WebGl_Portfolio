using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class VideoPlayYantra : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject player;
    public GameObject detector;
   // public TMP_Text txt;


    // Start is called before the first frame update
    void Start()
    {

        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Yantra.mp4");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = player.transform.position;
        Vector3 obstacpos = detector.transform.position;
        float distance = Vector3.Distance(playerpos, obstacpos);
        if (distance < 8f)
        {
            //txt.gameObject.SetActive(true);
           // if (Input.GetKeyDown(KeyCode.E))
           // {
                videoPlayer.Play();
               // txt.gameObject.SetActive(false);
           // }


        }

        else
        {
            videoPlayer.Pause();
           // txt.gameObject.SetActive(false);

        }
    }
}
