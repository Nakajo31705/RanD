using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Animation : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] private AudioClip SE_jamp;
    [SerializeField] private int Positionx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -1)
        {
            audioSource.PlayOneShot(SE_jamp);
        }
    }
}
