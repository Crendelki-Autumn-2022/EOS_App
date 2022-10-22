using System;
using UnityEngine;
using UnityEngine.UI;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    public Button lastButtonAdd;
    private void Awake()
    {
        if (current != null)
        {
            Destroy(gameObject);
        }
        else
        {
            current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        current.OnAddTask += LastUsedButton;
    }

    private void LastUsedButton(Button button)
    {
        lastButtonAdd = button;
    }

    public event Action<int> OnPointChange;
    public event Action<Button> OnAddTask;
    public event Action OnBlockAdded;
    public event Action OnBlockDeleted;

    public void PointChange(int point) => OnPointChange?.Invoke(point);
    public void AddTask(Button button) => OnAddTask?.Invoke(button);
    public void BlockDeleted() => OnBlockDeleted?.Invoke();
    public void BlockAdded() => OnBlockDeleted?.Invoke();
}
