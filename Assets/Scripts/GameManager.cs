using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI; 
    
    public void CompleteLevel()
    {
        Debug.Log("LEVEL COMPLETED!");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(hasGameEnded == false)
        {
            hasGameEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartDelay);
        }
        
    }

    public void Restart()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
