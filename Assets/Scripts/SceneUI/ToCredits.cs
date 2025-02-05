using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCredits : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("CreditsScreen");
    }
}
