using System;
using TMPro;
using UnityEngine;

public class PointsMovePoint : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public static PointsMovePoint current;
    public int score;
    private void Start()
    {
        score = 0;
        SetPoints(score);
        current = this;
        GameEvents.current.OnPointChange += SetPoints;
    }

    public int GetPoints()
    {
        return Convert.ToInt32(text);
    }

    public void SetPoints(int points)
    {
        score += points;
        text.text = score.ToString();
    }
}
