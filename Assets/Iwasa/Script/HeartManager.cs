using UnityEngine;

public class HeartManager : MonoBehaviour
{
    public static HeartManager Instance { get; private set; }
    public int collectedHearts = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // シーン間でオブジェクトを破棄しない
        }
        else
        {
            Destroy(gameObject); // 重複するインスタンスがあれば破棄
        }
    }

    public void AddHeart()
    {
        collectedHearts++;
        // ここで collectedHearts に基づく処理を追加できます
    }
}
