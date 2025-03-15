using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    public delegate void CloseHandler(UIWindow sender, WindowResult result);
    public event CloseHandler OnClose;

    public virtual System.Type Type { get { return this.GetType(); } }

    public Transform Root;

    public enum WindowResult
    {
        None = 0,
        Yes,
        No
    }

    public void Close(WindowResult result = WindowResult.None)
    {
        //SoundManager.Instance.PlaySound(SoundDefine.SFX_UI_Win_Close);�ر���Ч
        UIManager.Instance.Close(this.Type);
        if (this.OnClose != null)
        {
            this.OnClose(this, result);
        }
        this.OnClose = null;
    }

    public virtual void OnCloseClick()
    {
        this.Close();
    }

    public virtual void OnYesClick()
    {
        this.Close(WindowResult.Yes);
    }

    public virtual void OnNoClick()
    {
        this.Close(WindowResult.No);
    }


}
