using UnityEngine;

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
                Debug.Log("you hit a obstacle");
                break;
       }
        
    }
}
