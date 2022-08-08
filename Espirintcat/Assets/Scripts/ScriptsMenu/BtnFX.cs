using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnFX : MonoBehaviour
{
    public AudioSource source;
    public AudioClip hoverFx;
    public AudioClip clickFx;

     void Start()
    {
        
    }

     void Update()
    {
        
    }
    public void HoverSound()
    {
        source.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        source.PlayOneShot(clickFx);
    }
}
