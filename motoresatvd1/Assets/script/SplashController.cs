using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);

        GameManager.Instance.LoadScene("MenuPrincipal");
    }
}