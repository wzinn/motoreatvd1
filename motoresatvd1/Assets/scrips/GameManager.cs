using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

// GameState dentro do próprio GameManager
public enum GameState
{
    Iniciando,
    MenuPrincipal,
    Gameplay
}

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance;

    // Estado atual do jogo
    public GameState CurrentState;

    [Header("Player Input")]
    public PlayerInput playerInput;

    private void Awake()
    {
        // Verifica se já existe um GameManager
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
        // Estado inicial
        ChangeState(GameState.Iniciando);

        // Carrega a Splash
        LoadScene("Splash");
    }

    // Troca o estado do jogo
    public void ChangeState(GameState newState)
    {
        CurrentState = newState;

        Debug.Log("Estado atual: " + CurrentState);
    }

    // Controle de troca de cenas
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

        Debug.Log("Carregando cena: " + sceneName);

        SceneManager.LoadScene(sceneName);
    }

    // Alocação do input do jogador
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