using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score, _highScore;
    public Text scoreText;
    public Text highScoreText;
    public AudioClip clickSound;

    void Start()
    {
        _score = 0;
        _highScore = 0;
        scoreText.text = _score.ToString();
    }

    public void UpdateScore()
    {
        _score++;
        scoreText.text = _score.ToString();

        if (_score > _highScore)
        {
            highScoreText.text = _score.ToString();
            PlayerPrefs.SetInt("High Score: ", _score);
            PlayerPrefs.Save();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    
    public void ReturnMainMenu()
    {
        StartCoroutine(PlaySoundAndLoadScene());
    }

    private IEnumerator PlaySoundAndLoadScene()
    {
        AudioSource.PlayClipAtPoint(clickSound, Vector3.zero);
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

   /* public void ReturnMainMenu()
    {
        AudioSource.PlayClipAtPoint(audio.clip, Vector3.zero);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }*/


}