using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UISetting : UIWindow
{

    // �������ڻ�����
    public Slider volumeSlider;

    // �˻����˵���ť
    public Button backToMainMenuButton;
    private void Awake()
    {
        if (UIManager.Instance != null & UIManager.Instance.currentScene == 0)
        {
            this.backToMainMenuButton.gameObject.SetActive(false);
        }
    }

    // �������ڷ���
    public void OnVolumeChanged(float volume)
    {
        // ����ȫ������
        AudioListener.volume = volume;
        Debug.Log($"�����ѵ���Ϊ: {volume}");
    }

    // �˻����˵�����
    public void OnBackToMainMenuClicked()
    {
        // �������˵�����
        Debug.Log("���˻����˵�");
    }
}