using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public SpawnControl[] spawners;
    public float waveDelay;

    public TextMeshProUGUI scoreDisplay;
    public int score;

    public GameObject gameOverDisplay;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        StartCoroutine(nameof(SpawnWave));
    }

    IEnumerator SpawnWave()
    {
        spawners[Random.Range(0, spawners.Length)].Spawn(6);
        yield return new WaitForSeconds(waveDelay);
        StartCoroutine(nameof(SpawnWave));
        
    }

    public void UpdateScore()
    {
        scoreDisplay.text = "Score: " + score;
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        UpdateScore();
    }

    public void GameOver()
    {
        gameOverDisplay.SetActive(true);
        Invoke(nameof(ResetGame), 3);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
