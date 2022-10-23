using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    [SerializeField] private string sceneNameMain;

    public void MoveScene()
    {
        SceneManager.LoadScene(sceneNameMain);
    }
}
