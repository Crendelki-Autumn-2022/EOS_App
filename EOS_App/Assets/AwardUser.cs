using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AwardUser : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private void Start()
    {
        GameEvents.current.OnCountAward += Count;
    }
    private void Count()
    {
        text.text = "Баллов получите вы: " + (PointsMovePoint.current.score/2+Random.Range(1,5)).ToString();
    }
}
