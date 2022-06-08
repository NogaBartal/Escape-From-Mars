using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
       switch(other.gameObject.tag)
       {
            case "Friendly":
                Debug.Log("this thing is friendly");
                break;
            case "Finish":
                Debug.Log("Mission Acoplish");
                break;
            default:
                ReloadLevel();
                break;
       }
        
    }

    void ReloadLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
