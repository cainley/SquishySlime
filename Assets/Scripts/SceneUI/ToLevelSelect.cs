using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevelSelect : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
