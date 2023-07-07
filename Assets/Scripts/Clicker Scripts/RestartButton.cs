using UnityEngine;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private SceneLoader loader;

    public void RestartScene()
    {
        PlayerPrefs.DeleteAll();
        loader.ReloadCurrentScene();
    }
}
