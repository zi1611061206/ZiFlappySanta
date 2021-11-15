using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text txtPoint;
    public GameObject pnlEndGame;
    public Text txtEndPoint;
    public Button RestartButton;
    public Button StartButton;
    public Button LogOutButton;
    public bool isEndGame;
    bool isStartFirstTime = true;
    int gamePoint =0;

    public Sprite ButtonIdle;
    public Sprite ButtonHover;
    public Sprite ButtonClick;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        gamePoint = 0;
        isEndGame = false;
        isStartFirstTime = true;
        pnlEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isStartFirstTime)
            {
                StartGame();
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
    }

    public void RestartButtonClick()
    {
        RestartButton.GetComponent<Image>().sprite = ButtonClick;
    }

    public void RestartButtonHover()
    {
        RestartButton.GetComponent<Image>().sprite = ButtonHover;
    }

    public void RestartButtonIdle()
    {
        RestartButton.GetComponent<Image>().sprite = ButtonIdle;
    }

    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point: " + gamePoint.ToString();
    }

    void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        StartGame();
    }
    public void EndGame()
    {
        isEndGame = true;
        isStartFirstTime = false;
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtEndPoint.text = "Your Point\n " + gamePoint.ToString();
    }
}
