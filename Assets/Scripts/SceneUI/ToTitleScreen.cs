using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
