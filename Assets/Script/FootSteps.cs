using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClips;

    private void Step()
    {
        audioSource.PlayOneShot(audioClips);
    }


}
