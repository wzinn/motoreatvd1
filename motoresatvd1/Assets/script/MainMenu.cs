using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.LoadScene("GetStarted_Scene");
    }
}