using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void GoToScene(string sceneName) => SceneManager.LoadScene(sceneName);
}
