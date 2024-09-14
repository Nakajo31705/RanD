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
            DontDestroyOnLoad(gameObject); // �V�[���ԂŃI�u�W�F�N�g��j�����Ȃ�
        }
        else
        {
            Destroy(gameObject); // �d������C���X�^���X������Δj��
        }
    }

    public void AddHeart()
    {
        collectedHearts++;
        // ������ collectedHearts �Ɋ�Â�������ǉ��ł��܂�
    }
}
