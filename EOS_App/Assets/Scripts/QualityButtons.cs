using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class QualityButtons : MonoBehaviour
{
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Transform center;
    [SerializeField] private Transform left;
    [SerializeField] private Transform right;
    [SerializeField] private ScrollRect scroll;
    private bool isMoved;
    private int lastAddedPoint;

    private void Start()
    {
        isMoved = false;
        button1.onClick.AddListener(() => ChooseButton(button1));
        button2.onClick.AddListener(() => ChooseButton(button2));
        button3.onClick.AddListener(() => ChooseButton(button3));
    }

    private void ChooseButton(Button b)
    {
        print("used");
        StartCoroutine(StunLocked());

        if (!isMoved)
        {
            if (b == button1)
            {
                lastAddedPoint = 2;
                GameEvents.current.PointChange(lastAddedPoint);
                button2.transform.DOScale(Vector3.zero, 0.3f);
                button3.transform.DOScale(Vector3.zero, 0.3f);
            }
            else if (b == button2)
            {
                lastAddedPoint = 4;
                GameEvents.current.PointChange(lastAddedPoint);
                button1.transform.DOScale(Vector3.zero, 0.3f);
                button3.transform.DOScale(Vector3.zero, 0.3f);
            }
            else
            {
                lastAddedPoint = 6;
                GameEvents.current.PointChange(lastAddedPoint);
                button1.transform.DOScale(Vector3.zero, 0.3f);
                button2.transform.DOScale(Vector3.zero, 0.3f);
            }
            b.transform.DOMove(center.position, 0.3f);
            isMoved = true;
        }
        else
        {
            print(lastAddedPoint);
            LowerPoints();
            button1.transform.DOMove(left.position, 0.3f);
            button2.transform.DOMove(center.position, 0.3f);
            button3.transform.DOMove(right.position, 0.3f);
            button1.transform.DOScale(Vector3.one, 0.3f);
            button2.transform.DOScale(Vector3.one, 0.3f);
            button3.transform.DOScale(Vector3.one, 0.3f);
            isMoved = false;
        }
    }

    IEnumerator StunLocked()
    {

        scroll.StopMovement();
        scroll.enabled = false;
        yield return new WaitForSeconds(2f);
        scroll.enabled = true;
    }

    public void LowerPoints()
    {
        GameEvents.current.PointChange(-lastAddedPoint);
    }
}
