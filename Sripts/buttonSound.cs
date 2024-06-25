using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;

    public void clickSound()
    {
        myFx.PlayOneShot(clickFx);
    }

    public void stopSound()
    {
        myFx.Stop();
    }
}
