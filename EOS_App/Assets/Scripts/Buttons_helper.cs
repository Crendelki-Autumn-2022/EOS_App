using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Buttons_helper : MonoBehaviour
{
    public Button btn;
    public TextMeshProUGUI txt, txt2;
    public GameObject img, img1, img2, img3, img4, img5;

    void Start()
    {
        btn.onClick.AddListener(OnClicked);
    }

    public void OnClicked()
    {
        txt.gameObject.SetActive(false);
        img.SetActive(false);
        txt2.gameObject.SetActive(true);
        img1.SetActive(true);
    }
    public void ChangeText()
    {
        

        if (img2.activeSelf)
        {
            img2.SetActive(false);
            img3.SetActive(true);
            txt2.SetText("Здесь Вы можете выбрать дату исполнения");
        }
        
        else if (img3.activeSelf)
        {
            img3.SetActive(false);
            img4.SetActive(true);
            txt2.SetText("Здесь можно ознакомить других людей");
        }
        else if (img4.activeSelf)
        {
            img4.SetActive(false);
            txt2.gameObject.SetActive(false);
            img5.SetActive(false);
        }

        else
        {
            img1.SetActive(false);
            img2.SetActive(true);
            txt2.SetText("Здесь Вы можете указать/добавить исполнителя");
        }
    }
}

