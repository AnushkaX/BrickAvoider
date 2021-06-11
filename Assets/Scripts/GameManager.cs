
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

   public void EndGame() {

        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
