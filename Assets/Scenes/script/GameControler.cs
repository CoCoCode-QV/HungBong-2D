using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    [SerializeField]
    private GameObject Ball;
    [SerializeField]
    public float spawnTime;
    private float old_spawTime;
    UIManager g_UI;
    private int Score = 0;
    bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        old_spawTime = 0;
        g_UI = FindObjectOfType<UIManager>();
        g_UI.setScoreText("Score: " + Score);
    }

    // Update is called once per frame
    void Update()
    {
        old_spawTime -= Time.deltaTime;

        if (isGameOver)
        {
            old_spawTime = 0;
            g_UI.ShowGameOverPane(true);
           
            return;
        }

        if(old_spawTime <= 0)
        {
            SpawnBall();
            old_spawTime = spawnTime;
        }

    }
    private void SpawnBall()
    {
        Vector2 spawnPs = new Vector2(Random.Range(-10, 10), 7);
        if (Ball)
        {
            Instantiate(Ball, spawnPs, Quaternion.identity);
        }
    }
    public void Replay()
    {
        Score = 0;
        setisGameOver(false);
        g_UI.setScoreText("Score: " + Score);
        g_UI.ShowGameOverPane(false);
    }
    public void setScore(int value)
    {
        Score = value;
    }
   public int getScore()
    {
        return Score;
    }
    public void IncrementScore()
    {
        Score++;
        g_UI.setScoreText("Score: " + Score);
    }
    public bool IsGameOver()
    {
        return isGameOver;
    }
    public void setisGameOver(bool value)
    {
        isGameOver = value;
    }
    
}
