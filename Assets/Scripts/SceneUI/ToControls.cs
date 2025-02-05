using UnityEngine;
using UnityEngine.SceneManagement;

public class ToControls : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("ControlsScreen");
    }
}
