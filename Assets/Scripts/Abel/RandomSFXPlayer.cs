using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSFXPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] audioClips = null;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayRandomAudio()
    {
        audioSource.Stop();
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }
}
