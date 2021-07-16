using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    [SerializeField] private int _vrSceneIndex = 1;
    [SerializeField] private int _arSceneIndex = 2;

    public void GoToVRScene() => SceneManager.LoadScene(_vrSceneIndex);
    public void GoToARScene() => SceneManager.LoadScene(_arSceneIndex);
}
