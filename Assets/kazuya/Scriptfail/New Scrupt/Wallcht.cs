using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wallcht : MonoBehaviour
{
    public  GameObject WallObject;//壁のオブジェクト
    public GameObject RockObject;//生成する岩のオブジェクト
    public Vector2 dfRock;

    private int count;
    private bool PlaCh = false;
    public int selection = 0;
    void Start()
    {

    }

    void Update()
    {
        if (PlaCh)
        {
            Instantiate(RockObject, dfRock, Quaternion.identity);
            PlaCh = false;
            Destroy(WallObject);
        }
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlaCh = true;
        }

    }
}
