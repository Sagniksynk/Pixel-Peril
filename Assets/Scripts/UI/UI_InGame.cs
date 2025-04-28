using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_InGame : MonoBehaviour
{
    public static UI_InGame instance;
    public UI_FadeEffect fadeEffect { get; private set; } // read-only

    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI fruitText;

    [SerializeField] private GameObject pauseUI;
    private bool isPaused = false;

    private void Awake()
    {
        instance = this;

        fadeEffect = GetComponentInChildren<UI_FadeEffect>();
    }

    private void Start()
    {
        isPaused = false;
        fadeEffect.ScreenFade(0, 1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            PauseButton();
    }

    public void PauseButton()
    {
        //Debug.Log(isPaused);
        if (isPaused)
        {
            isPaused = false;
            Time.timeScale = 1;
            pauseUI.SetActive(false);
        }
        else
        {
            isPaused = true;
            Time.timeScale = 0;
            pauseUI.SetActive(true);
        }
    }

    public void GoToMainMenuButton()
    {
        bool wasPaused = isPaused;
        if (wasPaused)
        {
            pauseUI.SetActive(false);
        }
        Time.timeScale = 1f;
        fadeEffect.ScreenFade(1, 1.5f, () =>
        {
            SceneManager.LoadScene(0);
        });
    }


    public void UpdateFruitUI(int collectedFruits, int totalFruits)
    {
        fruitText.text = collectedFruits + "/" + totalFruits;
    }

    public void UpdateTimerUI(float timer)
    {
        timerText.text = timer.ToString("00") + " s";
    }
    public bool IsPaused()
    {
        return isPaused;
    }
}
