using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlaneComponent : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            // Restarts A Level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
