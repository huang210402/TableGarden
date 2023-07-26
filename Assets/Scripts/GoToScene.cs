using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public void GoCartoon()
    {
        SceneManager.LoadScene("CartoonGarden");
    }

    public void GoReal()
    {
        SceneManager.LoadScene("RealGarden");
    }

    public void GoMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
