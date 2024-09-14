using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;//�I�u�W�F�N�g�̃X�v���C�g��ύX������
    private bool fierst = true;//�ŏ��̈��ډ��̃`�F�b�N
    public Sprite Flag_1;//�擾�O�̃X�v���C�g
    public Sprite Flag_2;//�擾��̃X�v���C�g
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
