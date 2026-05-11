using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashController : MonoBehaviour
{
    private IEnumerator Start()
    {
        Debug.Log("Splash iniciou");

        yield return new WaitForSeconds(2f);

        Debug.Log("Mudando cena");

        SceneManager.LoadScene("MenuPrincipal");
    }
}