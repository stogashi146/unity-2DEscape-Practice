using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void ToTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
    public void ToGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void ToClearScene()
    {
        AudioManager.instance.playSE(AudioManager.SE.Out);
        SceneManager.LoadScene("Clear");
    }

}
