using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart_catch : MonoBehaviour
{
    public Image heartIllustration; // イラストを表示するためのUIイメージ
    public Sprite initialSprite; // 初期状態のイラスト
    public Sprite secondStageSprite; // 2段階目のイラスト
    public Sprite thirdStageSprite; // 3段階目のイラスト
    public Sprite finalStageSprite; // 最終段階のイラスト

    private int collectedHearts = 0;

    private void Start()
    {
        // PlayerPrefs からハートの状態を読み込む
        collectedHearts = PlayerPrefs.GetInt("CollectedHearts", 0);

        // ゲーム開始時に初期状態のイラストを設定
        heartIllustration.sprite = initialSprite;
        UpdateHeartIllustration();
    }

    private void OnEnable()
    {
        // ステージがロードされた時にハートの所持状況をリセット
        OnStageReset();
    }

    public void CollectHeart()
    {
        collectedHearts++;
        UpdateHeartIllustration();

        // ハートの状態を PlayerPrefs に保存
        PlayerPrefs.SetInt("CollectedHearts", collectedHearts);
        PlayerPrefs.Save();
    }

    private void UpdateHeartIllustration()
    {
        switch (collectedHearts)
        {
            case 1:
                heartIllustration.sprite = secondStageSprite;
                Debug.Log("イラスト変化1");
                break;
            case 2:
                heartIllustration.sprite = thirdStageSprite;
                Debug.Log("イラスト変化2");
                break;
            case 3:
                heartIllustration.sprite = finalStageSprite;
                Debug.Log("イラスト変化3");
                break;
            default:
                heartIllustration.sprite = initialSprite;
                Debug.Log("イラスト初期化");
                break;
        }
    }

    // ゲームクリア後の処理
    public void OnGameClear()
    {
        // ハートの状態を PlayerPrefs に保存
        PlayerPrefs.SetInt("CollectedHearts", collectedHearts);
        PlayerPrefs.Save();
    }

    // ステージリセット時の処理
    public void OnStageReset()
    {
        // ハートの状態をリセット
        collectedHearts = 0;
        heartIllustration.sprite = initialSprite;
        PlayerPrefs.SetInt("CollectedHearts", collectedHearts);
        PlayerPrefs.Save();
    }
}
