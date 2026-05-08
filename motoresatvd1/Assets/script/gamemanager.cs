using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState CurrentState;

    [Header("Player Input")]
    public PlayerInput playerInput;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);

        // Carrega Splash após iniciar
        LoadScene("Splash");
    }

    // Mudança de estados
    public void ChangeState(GameState newState)
    {
        CurrentState = newState;

        Debug.Log("Estado atual: " + CurrentState);
    }

    // Controle centralizado de cenas
    public void LoadScene(string sceneName)
    {
        switch (sceneName)
        {
            case "Splash":
                ChangeState(GameState.Iniciando);
                break;

            case "MenuPrincipal":
                ChangeState(GameState.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                ChangeState(GameState.Gameplay);
                break;
        }

        SceneManager.LoadScene(sceneName);
    }

    // Alocação de Input
    public void AssignInput(PlayerInput input)
    {
        playerInput = input;

        Debug.Log("Input alocado ao jogador.");
    }

    // Sair do jogo
    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}