using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private FinalDoor finalDoor;
    [SerializeField] private AudioClip musicNote;
    private AudioSource buttonAudioSource;

    private void Start()
    {
        buttonAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonAudioSource.PlayOneShot(musicNote);
        finalDoor.currentSequence.Add(gameObject.tag);
        finalDoor.CheckSequence();
    }
}
