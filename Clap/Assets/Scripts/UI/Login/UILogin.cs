using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILogin : MonoBehaviour
{
    public UIManager Manager;

    [Header("Button References")]
    [SerializeField] private Button SingleBtn;
    [SerializeField] private Button OnlineBtn;
    [SerializeField] private Button HelpBtn;
    [SerializeField] private Button llustratedBtn;
    [SerializeField] private Button DeveloperBtn;
    [SerializeField] private Button SettingsBtn;
    [SerializeField] private Button QuitBtn;

    public string currentSence = "UILogin";

    void Start()
    {

    }

    #region ��ť�¼�ʵ��
    public void OnSingle()
    {
        SceneManager.Instance.LoadScene("MainSence");
    }

    public void OnOnline()
    {
        //SceneManager.Instance.LoadScene("CharSelect");
    }

    public void OnHelp()
    {
        //SceneManager.LoadScene("TutorialScene");
    }

    public void Onllustrated()
    {
        BookManager.Instance.ShowBook();
    }

    public void OnDeveloper()
    {
        UIManager.Instance.Show<UIDeveloper>();
    }

    public void OnSetting()
    {
        UIManager.Instance.Show<UISetting>();
    }

    public void OnQuit()
    {
        Application.Quit();
    }
    #endregion

    #region ��������
    // ����չ�������ơ��������õȹ���
    public void SetMasterVolume(float value)
    {
        AudioListener.volume = value;
    }
    
    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
    #endregion
}