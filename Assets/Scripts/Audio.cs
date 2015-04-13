using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{
    void Start()
    {
        audio.Play();
        audio.Play(44100);
    }
}