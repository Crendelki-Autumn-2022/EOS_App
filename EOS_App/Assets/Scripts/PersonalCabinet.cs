using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersonalCabinet : MonoBehaviour
{
    Information info = new Information();

    public GameObject achivementsPage;
    public GameObject leadersPage;
    public GameObject LineAchive;
    public GameObject LineLeaders;

    public GameObject panelReward;
    public GameObject btnReward;
    public GameObject infoAchive;

    public TextMeshProUGUI currentLvl;
    public TextMeshProUGUI currentExp;
    public TextMeshProUGUI Letopisec;

    void Start()
    {
        currentLvl.SetText("Директор, " + info.lvl.ToString() + " уровень");
        currentExp.SetText(info.exp.ToString() + " б.");
    }

    public void ActiveAchive()
    {
        achivementsPage.SetActive(true);
        LineAchive.SetActive(true);
        LineLeaders.SetActive(false);
        leadersPage.SetActive(false);
    }

    public void ActiveLeaders()
    {
        achivementsPage.SetActive(false);
        LineAchive.SetActive(false);
        LineLeaders.SetActive(true);
        leadersPage.SetActive(true);
    }

    public void toGetReward()
    {
        panelReward.SetActive(true);
    }

    public void GettingReward()
    {
        panelReward.SetActive(false);
        info.exp += 5;
        currentExp.SetText(info.exp.ToString() + " б.");
        Letopisec.SetText("Летописец V");
        btnReward.SetActive(false);
        infoAchive.SetActive(true);
    }
}
