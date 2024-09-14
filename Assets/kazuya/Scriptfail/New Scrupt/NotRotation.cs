using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotRotation : MonoBehaviour
{
    public int x;
    public int y;
    public int z;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(x, y, z);
    }
}
