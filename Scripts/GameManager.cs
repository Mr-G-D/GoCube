using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Boolean game = true;

    public GameObject finishUI;
    public void EndGame()
    {
        if (game)
        {
            game = false;
            Debug.Log("GameOver");
            Invoke("restart", 2f);
        }
    }

    public void finish()
    {
        finishUI.SetActive(true);
        game = false;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
