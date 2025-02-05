using UnityEngine;
using UnityEngine.SceneManagement;

public class NextWin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("WinScreen");
    }
}
