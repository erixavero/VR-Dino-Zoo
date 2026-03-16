using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTour : MonoBehaviour
{
    public string targetTag;

    private void restartOnTrigger(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
