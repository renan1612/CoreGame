using UnityEngine;
internal class InputBox
{
    static Object cacheObject = null;

    public static UIInputBox Show(string message, string title = "", string btnOK = "ȷ��", string btnCanel = "ȡ��", string emptyTips = "���벻��Ϊ��")
    {
        if (cacheObject == null)
        {
            cacheObject = Resloader.Load<Object>("UI/UIInputBox");
        }

        GameObject go = (GameObject)GameObject.Instantiate(cacheObject);
        UIInputBox InputBox = go.GetComponent<UIInputBox>();
        InputBox.Init(title, message, btnOK, btnCanel, emptyTips);
        return InputBox;
    }
}
