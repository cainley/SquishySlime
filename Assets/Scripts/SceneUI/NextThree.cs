using UnityEngine;
using UnityEngine.SceneManagement;
public class NextThree : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("LevelThree");
    }
}
