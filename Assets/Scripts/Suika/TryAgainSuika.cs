using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TryAgainSuika : MonoBehaviour
{
    public void tryagain()
    {
        SceneManager.LoadScene("Suika");
    }
}
