using DG.Tweening;
using UnityEngine;

public class ScoreAwardPopUp : MonoBehaviour
{
    public void SizeUp()
    {
        GameEvents.current.CountAward();
        gameObject.transform.DOScale(Vector3.one, 0.3f);
    }

    public void SizeDown()
    {
        gameObject.transform.DOScale(Vector3.zero, 0.3f);
        print("scale");
    }
}
