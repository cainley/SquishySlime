using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTwo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("LevelTwo");
    }
}
