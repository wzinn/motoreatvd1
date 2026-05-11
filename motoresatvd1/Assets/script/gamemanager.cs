using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);

            Debug.Log("GameManager criado");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        LoadScene("Splash");
    }

    public void LoadScene(string sceneName)
    {
        Debug.Log("Carregando: " + sceneName);

        SceneManager.LoadScene(sceneName);
    }
}