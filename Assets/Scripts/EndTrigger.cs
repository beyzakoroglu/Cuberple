using Unity.VisualScripting;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{   
    public GameManager gameManager;
    void OnTriggerEnter() 
    {
        
        gameManager.CompleteLevel();
    }
}
