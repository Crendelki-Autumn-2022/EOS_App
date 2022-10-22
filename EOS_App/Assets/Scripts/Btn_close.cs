using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Btn_close : MonoBehaviour
{
    public Button btn_close;
    public TextMeshProUGUI txt;

    void Start()
    {
        btn_close.onClick.AddListener(Close);
    }

    public void Close()
    {
        txt.gameObject.SetActive(false);
        btn_close.gameObject.SetActive(false);
    }
}
