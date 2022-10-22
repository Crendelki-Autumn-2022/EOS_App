using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AddTask : MonoBehaviour
{

    [SerializeField] private GameObject block;
    [SerializeField] private Transform blockHolder;
    private Button button;

    private void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(CreateBlock);
    }

    private void CreateBlock()
    {
        GameEvents.current.AddTask(button);
        StartCoroutine(BlockRollOut());
        print(PlayerPrefs.GetInt("task", 1));
        PlayerPrefs.SetInt("task", PlayerPrefs.GetInt("task", 1) + 1);
        print(PlayerPrefs.GetInt("task"));
    }

    IEnumerator BlockRollOut()
    {
        var g = Instantiate(block, blockHolder);
        g.transform.localScale = Vector3.zero;
        g.transform.DOScale(Vector3.one, 0.3f);
        yield return new WaitForSeconds(0.3f);
        gameObject.transform.DOScale(Vector3.zero, 0.1f);
        yield return new WaitForSeconds(0.1f);
        GameEvents.current.BlockAdded();
    }

    public void SizeUp()
    {
        gameObject.transform.DOScale(Vector3.one, 0.2f);
    }
}
