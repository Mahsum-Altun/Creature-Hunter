using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int takeDamage;
    private AudioSource audioSource;
    public AudioClip audioClips;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.TryGetComponent<PlayerDamage>(out PlayerDamage playerDamageComponent))
        {
            playerDamageComponent.TakeDamage(takeDamage);
        }
        audioSource.PlayOneShot(audioClips);
    }
}
