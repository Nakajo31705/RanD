using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMouseButton : MonoBehaviour
{
    public AudioClip SE_click;
    AudioSource audioSource;//オーディオの読み込み
    private bool Button = true;
    private int index = 0;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButtonDown(0))
            {
                Button = false;
                audioSource.PlayOneShot(SE_click);
                Debug.Log("SE_click");
            }
        
    }
}
