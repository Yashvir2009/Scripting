using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Timer : MonoBehaviour
{
    private int minutes = 0;
    private float seconds = 0f;

    private void Update()
    {
        // Update seconds using deltaTime
        seconds += Time.deltaTime;

        // Check if seconds reach 60, then increment minutes and reset seconds
        if (seconds >= 60f)
        {
            seconds -= 60f;
            minutes++;

            // If there are no minutes left, restart the game level
            if (minutes >= 60)
            {
                RestartLevel(); // You need to implement this method
            }
        }
    }

    private void RestartLevel()
    {
        int sceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
}
