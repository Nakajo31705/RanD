using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    AudioSource audioSource;
    private new Rigidbody2D rigidbody;
    public float xSpeed;
    public AudioClip SE_rock;
    public int selection;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

     void Update()
    {
        if(xSpeed > 0)
        {
            transform.Rotate(new Vector3(0, 0, -5));
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, 5));
        }
        if(transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(xSpeed, rigidbody.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))//�ǂɂ��������玩�g������
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("breakWall"))//����ǂɂ���������Ώ��ł���
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("BreakingWall"))//���������A�I�u�W�F�N�g����������
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            audioSource.PlayOneShot(SE_rock);
        }
    }
}
