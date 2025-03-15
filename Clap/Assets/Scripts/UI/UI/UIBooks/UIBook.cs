
using Common.Data;
using GameServer.Managers;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Unity.VisualScripting;
using System.Collections;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using static UnityEditor.Progress;
using TMPro;

public class UIBook : UIWindow
{
    // UI�����
    [SerializeField] private UIInputBox Input;

    // Ԥ��������
    [SerializeField] private GameObject bookItem; 
    [SerializeField] private TextMeshProUGUI sreachcontent;
    [SerializeField] private Button Button;
    public UIBookmessage message;

    public void Start()
    {
        //����UIBook
        StartCoroutine(InitItems());
    }

    IEnumerator InitItems()//��ʼ��
    {
        sreachcontent.text = null;
        Button.gameObject.SetActive(false);
        foreach (var kv in DataManager.Instance.Items)
        {
            GameObject go = Instantiate(bookItem, Root);
            UIBookItem ui = go.GetComponent<UIBookItem>();
            ui.SetBookItem(kv.Key, kv.Value, this);
        }
        yield return null;
    }

    public void OnSreach()
    {
            InputBox.Show("����Ҫ��ѯ�Ŀ���").OnSubmit += SreachCore;
    }

    private bool SreachCore(string input, out string tips)
    {
        tips = "";
        string CoreName =input;
        foreach (Transform item in Root)
        {
            if (!item.name.Contains(CoreName, StringComparison.OrdinalIgnoreCase))
            {
                item.gameObject.SetActive(false); // ���ز�ƥ�����
            }
        }
        sreachcontent.text = input;
        Button.gameObject.SetActive(true);
        return true;
    }
    public void ClearSreach()
    {
        sreachcontent.text = null;
        Button.gameObject.SetActive(false);
        foreach (Transform item in Root)
        {
            item.gameObject.SetActive(true);
        }
    }
}