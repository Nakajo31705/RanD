using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private GameObject player;
    public AudioClip SE_footStep;
    PlCor plCor;

    AudioSource audioSource;
    void Start()
    {
        player = GameObject.Find("Player(Clone)");
        plCor = player.GetComponent<PlCor>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (plCor.prri == true)
            {
                audioSource.mute = false;
            }
            else
            {
                audioSource.mute = true;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.mute = true;
        }
    }
}
