using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartDelay = 1f;
    public Text scoreValue;
    public GameObject levelCompleteUI;
    public GameObject player;
    // End Game
    public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("RestartGame", RestartDelay);
        }
        
    }

    // Level Complete
    public void LevelComplete()
    {
        scoreValue.text = player.transform.position.z.ToString("0");
        levelCompleteUI.SetActive(true);
        Invoke("loadNextScene", RestartDelay);
    }

    void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Restart Game
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
