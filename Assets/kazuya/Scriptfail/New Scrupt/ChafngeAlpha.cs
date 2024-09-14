using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChafngeAlpha : MonoBehaviour
{
    [SerializeField] private float FadeTime;//フィードさせる時間
    private float Timer;
    void Start()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = 0;//コンポーネントを取得して、透明にする
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= FadeTime)
        {
            this.gameObject.GetComponent<CanvasGroup>().alpha = 1;
        }
        
    }
}
