using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;     // Reference to the score UI
    public GameObject gameOverText;       // Game Over text object
    public GameObject tryAgainButton;     // Try Again button object
    public int gameOverScore = -10;       // Score threshold for game over

    private bool isGameOver = false;

    void Start()
    {
        Debug.Log("ScoreManager initialized");
        UpdateUI();

        if (gameOverText != null)
            gameOverText.SetActive(false);

        if (tryAgainButton != null)
            tryAgainButton.SetActive(false);

        Time.timeScale = 1f; // Ensure time is running normally on start
    }

    public void AddScore(int amount)
    {
        if (isGameOver) return;

        score += amount;
        Debug.Log($"Score changed by {amount}. New score: {score}");
        UpdateUI();

        if (score <= gameOverScore)
        {
            GameOver();
        }
    }

    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
    }

    private void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over!");

        if (gameOverText != null)
            gameOverText.SetActive(true);

        if (tryAgainButton != null)
            tryAgainButton.SetActive(true);

        Time.timeScale = 0f; // Pause game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Resume time
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}