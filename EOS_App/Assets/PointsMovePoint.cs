using System;
using TMPro;
using UnityEngine;

public class PointsMovePoint : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public static PointsMovePoint current;
    private void Start()
    {
        current = this;
    }

    public int GetPoints()
    {
        return Convert.ToInt32(text);
    }

    public void SetPoints(int points)
    {
        text.text = points.ToString();
    }
}
