using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WindMove : MonoBehaviour
{
    public int WindMode;
    private GameObject player;
    private GameObject player2;
    private GameObject Manager;
    PlCor plCor;
    PlCor plCor2;
    PlayerManager PlMane;
    AreaEffector2D area;
    public float Angle;//���I�u�W�F�N�g�̊p�x
    public float Magnitude;//���̋���

    public AudioClip SE_wind;
    AudioSource audioSource;
    private void Start()
    {
        Manager = GameObject.Find("PlayerManager");
        PlMane = Manager.GetComponent<PlayerManager>();
        audioSource = GetComponent<AudioSource>();
        player = GameObject.Find("Player(Clone)");
        plCor = player.GetComponent<PlCor>();
        if (PlMane.Player2 != null)
        {
            player2 = GameObject.Find("Player 2(Clone)");
            plCor2 = player2.GetComponent<PlCor>();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (area == null)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                audioSource.PlayOneShot(SE_wind);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (area == null)
        {
            if (plCor.PlayerNo == 1)
            {
                if (plCor.Playerindex == 1 && WindMode == 0)
                {
                    gameObject.AddComponent<AreaEffector2D>();
                    area = GetComponent<AreaEffector2D>();
                    area.forceAngle = Angle;
                    area.forceMagnitude = Magnitude;
                }
                else if (plCor.Playerindex == 2 && WindMode == 1)
                {
                    gameObject.AddComponent<AreaEffector2D>();
                    area = GetComponent<AreaEffector2D>();
                    area.forceAngle = Angle;
                    area.forceMagnitude = Magnitude;
                }
                else if (plCor.Playerindex == 3 && WindMode == 2)
                {
                    gameObject.AddComponent<AreaEffector2D>();
                    area = GetComponent<AreaEffector2D>();
                    area.forceAngle = Angle;
                    area.forceMagnitude = Magnitude;
                }
                else if (WindMode == 3)
                {
                    gameObject.AddComponent<AreaEffector2D>();
                    area = GetComponent<AreaEffector2D>();
                    area.forceAngle = Angle;
                    area.forceMagnitude = Magnitude;
                }
                if (PlMane.Player2 != null)
                {
                    if (plCor2.PlayerNo == 2)
                    {
                        if (plCor2.Playerindex == 1 && WindMode == 4)
                        {
                            gameObject.AddComponent<AreaEffector2D>();
                            area = GetComponent<AreaEffector2D>();
                            area.forceAngle = Angle;
                            area.forceMagnitude = Magnitude;
                        }
                        else if (plCor2.Playerindex == 2 && WindMode == 5)
                        {
                            gameObject.AddComponent<AreaEffector2D>();
                            area = GetComponent<AreaEffector2D>();
                            area.forceAngle = Angle;
                            area.forceMagnitude = Magnitude;
                        }
                        else if (plCor2.Playerindex == 3 && WindMode == 6)
                        {
                            gameObject.AddComponent<AreaEffector2D>();
                            area = GetComponent<AreaEffector2D>();
                            area.forceAngle = Angle;
                            area.forceMagnitude = Magnitude;
                        }
                        else if (WindMode == 3)
                        {
                            gameObject.AddComponent<AreaEffector2D>();
                            area = GetComponent<AreaEffector2D>();
                            area.forceAngle = Angle;
                            area.forceMagnitude = Magnitude;
                        }
                    }
                }

            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject.GetComponent<AreaEffector2D>());
            Debug.Log("Destroy3");
        }
    }
}

