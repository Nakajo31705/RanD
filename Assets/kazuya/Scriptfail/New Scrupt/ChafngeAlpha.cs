using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChafngeAlpha : MonoBehaviour
{
    [SerializeField] private float FadeTime;//�t�B�[�h�����鎞��
    private float Timer;
    void Start()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = 0;//�R���|�[�l���g���擾���āA�����ɂ���
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
