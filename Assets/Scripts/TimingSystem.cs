using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using UnityEngine.UI;
public class TimingSystem : MonoBehaviour
{
    public Slider slider;
    
    private float progress = 0f;

    public float targetTime;
    public float startTime;
    public float time = 0;

    public AudioSource audioSource;
    public GameObject boomScreen;
    public AudioClip sound1;
    private bool isFinished = false;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 2f;

        progress = Mathf.Clamp01(time / .9f);
        slider.value = Mathf.Lerp(startTime, targetTime, progress);
        
        if (!isFinished)
        {
            time += Time.deltaTime * 2;
        }
        else
        {
            time -= Time.deltaTime * 2;
            if (isFinished && progress <= startTime)
            {
                isFinished = false;
            }
        }

        if (boomScreen != null)
        {
            if (boomScreen.GetComponent<Image>().color.a > 0)
            {
                var color = boomScreen.GetComponent<Image>().color;
                
                color.a -= 0.01f;
                
                boomScreen.GetComponent<Image>().color = color;
            }
        }

        if (progress == targetTime)
        {
            isFinished = true;
        }


        if (progress >= 0.4 && progress <= 0.6)
        {
                   
            if (Input.GetKeyDown(KeyCode.Space)){
                Debug.Log("Hit");
                audioSource.clip = sound1;
                audioSource.Play();
                bam();
            }
        }
    }

    void bam()
    {
        var color = boomScreen.GetComponent<Image>().color;
        color.a = .8f;
        
        boomScreen.GetComponent<Image>().color = color;
    }
}
