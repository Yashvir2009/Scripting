using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    private int coins;
    public AudioSource audioSource;
    public AudioClip damageSound;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoins()
    {

        //Increasing the number of coins per unit
        coins++;

        //Printing information about collected coins
        print("Collected coins: " + coins);

    }
     
        // Damage
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health >0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Player's health: " + health);
        }
        else
        {
            int sceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
        }
       
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}