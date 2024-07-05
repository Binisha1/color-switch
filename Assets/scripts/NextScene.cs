using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void Loadnext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
