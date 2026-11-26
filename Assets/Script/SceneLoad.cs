using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    [SerializeField] private string loadSceneName;

    //シーンのロード
    public void LoadScene()
    {
        SceneManager.LoadScene(loadSceneName);
    }
}
