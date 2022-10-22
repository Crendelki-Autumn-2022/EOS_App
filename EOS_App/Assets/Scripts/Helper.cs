using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Helper : MonoBehaviour
{
    public Button btn;
    public TextMeshProUGUI txt;
    public GameObject rrr;

    void Start()
    {
        btn.onClick.AddListener(OnClicked);
    }

    public void OnClicked()
    {
        rrr.GetComponent<Graphic>().color = Color.red;
        txt.gameObject.SetActive(true);
       txt.SetText("Success!!!");
    }
}

