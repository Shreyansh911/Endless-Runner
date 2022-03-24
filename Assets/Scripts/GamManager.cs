using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamManager : MonoBehaviour
{
    public int Score;
    public int HighScore;

    [SerializeField] Text _timer, _score, _finalScore, _highScore;
    [SerializeField] GameObject _ui, _controls, _gameOverUI;

    float _time = 120;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        HighScore = PlayerPrefs.GetInt("HighScore", 0);

        _ui.SetActive(true);
        _controls.SetActive(true);
        _gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _time -= 1 * Time.deltaTime;

        _timer.text = Mathf.RoundToInt(_time).ToString();
        _score.text = "Score: " + Score;

        _finalScore.text = "Score: " + Score;

        if (_time <= 0)
        {
            Time.timeScale = 0;
            _gameOverUI.SetActive(true);
        }

        if(Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }

        _highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
