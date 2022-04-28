using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;

    public GameObject GameOverPane;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setScoreText(string txt)
    {
        if (ScoreText)
        {
            ScoreText.text = txt;
        }
    }
    public void ShowGameOverPane(bool isShow)
    {
        if (GameOverPane)
        {
            GameOverPane.SetActive(isShow);
        }
    }
}
