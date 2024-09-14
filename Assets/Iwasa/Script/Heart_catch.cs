using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Heart_catch : MonoBehaviour
{
    public Image heartIllustration; // イラストを表示するためのUIイメージ
    public Sprite initialSprite; // 初期状態のイラスト
    public Sprite secondStageSprite; // 1つ取得時のイラスト
    public Sprite thirdStageSprite; // 2つ取得時のイラスト
    public Sprite finalStageSprite; // 3つ取得時のイラスト

    public static int collectedHearts = 0;
    private const int maxHearts = 3; // ハートの最大数を3に固定


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        // すでに保存されているハートの数があるか確認し、それに基づいて初期化
        if (PlayerPrefs.HasKey("CollectedHearts"))
        {
            collectedHearts = PlayerPrefs.GetInt("CollectedHearts");
        }
        else
        {
            collectedHearts = 0; // 初回起動時やリセット後に初期化
        }

        UpdateHeartIllustration();

        // シーンロードイベントに登録
        SceneManager.sceneLoaded += OnSceneLoaded;
        Debug.Log("シーンロードされました");
    }

    private void OnDestroy()
    {
        // シーンロードイベントから解除
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // シーンがロードされた時に呼び出されるメソッド
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // StageSelectシーンに入ったらハートをリセット
        if (scene.name == "StageSelect")
        {
            OnStageReset(); // リセット処理
        }
        else
        {
            UpdateHeartIllustration();
        }
    }

    public void CollectHeart()
    {
        // ハートの所持数が最大値（3）に達している場合、取得しない
        if (collectedHearts >= maxHearts)
        {
            return;
        }
        // ハートを取得し、状態を更新
        collectedHearts++;
        UpdateHeartIllustration();
        SaveHeartState();
    }

    private void UpdateHeartIllustration()
    {
        if (heartIllustration == null)
        {
            Debug.Log("heartIllustration が null です。");
            return;
        }

        // ハートの所持数に応じて適切なイラストを表示
        switch (collectedHearts)
        {
            case 0:
                heartIllustration.sprite = initialSprite;
                Debug.Log("イラスト初期化");
                break;
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
                heartIllustration.sprite = finalStageSprite;
                Debug.Log("イラスト変化 (最大値)");
                break;
        }
    }


    // ハートの状態を PlayerPrefs に保存
    public void SaveHeartState()
    {
        PlayerPrefs.SetInt("CollectedHearts", collectedHearts);
        PlayerPrefs.Save();
    }

    // ステージリセット時の処理
    public void OnStageReset()
    {
        // ハートの状態をリセット
        collectedHearts = 0;
        // 初期状態のイラストを設定
        UpdateHeartIllustration();
        SaveHeartState();
    }
}
