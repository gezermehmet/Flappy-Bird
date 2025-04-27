using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score, _highScore;
    public Text scoreText;
    public Text highScoreText;

    void Start()
    {
        _score = 0;
        _highScore = 0;
        scoreText.text = _score.ToString();
    }

    public void UpdateScore()
    {
        _score++;
        scoreText.text = string.Format("Hakuş Hoplatıldı: {0}", _score);
        //scoreText.text = "Hakuş Hoplatıldı: " + _score.ToString();

        if (_score > _highScore)
        {
            highScoreText.text = _score.ToString();
            PlayerPrefs.SetInt("High Score: ", _score);
            PlayerPrefs.Save();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}