using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void ReloadCurrentScene()
    {
        int sceneID = SceneManager.GetActiveScene().buildIndex;
        LoadScene(sceneID);
    }
}
