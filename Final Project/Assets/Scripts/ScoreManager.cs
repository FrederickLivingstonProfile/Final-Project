using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString() + "POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + " POINTS";
    }

    private void Awake()
    {
        instance = this;
    }

    public void GoToWin()
    {
        // Go to the GameOver scene
        SceneManager.LoadScene("Win");
    }




}