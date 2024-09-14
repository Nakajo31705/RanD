using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onleft : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public int Speed;
    public int RoteX;
    public int RoteY;
    public float RoteZ;
    public float Rote;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        RoteZ -= Rote*Time.deltaTime;
        rigidbody.velocity = new Vector2(Speed, rigidbody.velocity.y);
        transform.eulerAngles = new Vector3(RoteX, RoteY, RoteZ);
    }
}
