using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TryAgainFisher : MonoBehaviour
{
public void tryAgain()
    {
        SceneManager.LoadScene("FishTiming");
    }
}
