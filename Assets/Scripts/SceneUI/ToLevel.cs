using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel : MonoBehaviour
{
    public void levelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }
    public void levelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    public void levelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
}
