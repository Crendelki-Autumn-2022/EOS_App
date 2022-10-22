using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    [SerializeField] private Button buttonClose;
    [SerializeField] private TextMeshProUGUI textTask;

    private void Start()
    {
        buttonClose.onClick.AddListener(Close);
        textTask.text = "Поручение #" + PlayerPrefs.GetInt("task",2);
    }

    private void Close()
    {
        gameObject.transform.DOScale(Vector3.one*1.5f, 0.2f);
        gameObject.transform.DOShakeRotation(0.4f,10,10,12);
        
        StartCoroutine(DelayedDestroy());
        PlayerPrefs.SetInt("task", PlayerPrefs.GetInt("task") - 1);
        if (PlayerPrefs.GetInt("task") == 1)
        {
            print("закрыть вкладку");
        }

    }

    IEnumerator DelayedDestroy()
    {
        GameEvents.current.BlockDeleted();
        yield return new WaitForSeconds(0.2f);
        GameEvents.current.lastButtonAdd.GetComponent<AddTask>().SizeUp();
        gameObject.transform.DOScale(Vector3.zero, 0.3f);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
