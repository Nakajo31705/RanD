using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBlink : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer eyeimage;

    [SerializeField]
    Sprite[] sparray;

    public int cnt = 0;    //まばたきするタイミングカウンタ
    public int blinkcnt = 120;  //まばたきするタイミング
    public int aniPos = 0; //アニメーション位置
    public int frate = 6; //アニメーションフレーム

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cnt++;
        cnt %= blinkcnt;
        if (cnt == 0)
        {
            aniPos = frate * 3;
        }
        if (aniPos > 0)
        {
            aniPos--;
            eyeimage.sprite = sparray[aniPos / frate];
        }
    }
}
