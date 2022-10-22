using DG.Tweening;
using TMPro;
using UnityEngine;

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
        panelReward.transform.localScale = Vector3.zero;
        print(panelReward.transform.localScale);
        panelReward.transform.DOScale(Vector3.one, 1f);
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
