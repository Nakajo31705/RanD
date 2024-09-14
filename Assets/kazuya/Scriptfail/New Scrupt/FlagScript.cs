using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;//オブジェクトのスプライトを変更させる
    private bool fierst = true;//最初の一回目化のチェック
    public Sprite Flag_1;//取得前のスプライト
    public Sprite Flag_2;//取得後のスプライト
    public AudioClip SE_savePoint;
    AudioSource audioSource;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (fierst)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                spriteRenderer.sprite = Flag_2;
                fierst = false;
                audioSource.PlayOneShot(SE_savePoint);
            }
        }
    }
}
