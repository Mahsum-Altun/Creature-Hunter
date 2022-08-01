using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public PlayerHealth playerHealth;
    public AudioSource audioSource;
    public AudioClip[] adClips;
    bool playerDieClips = false;
    public GameObject touchScript;
    public GameObject cameraColor;
    public GameObject weaponDie;
    public Button fireButton;
    public Button weaponSelectButton;


    public Animator playerdie;
    public int delay;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        playerHealth.SetMaxHealth(maxHealth);
        playerdie = GameObject.Find("Player").GetComponent<Animator>();


    }





    // Update is called once per frame
    void Update()
    {

        if (currentHealth < 0 && playerDieClips == false)
        {
            playerDieClips = true;
            bool Playerdie = true;
            playerdie.SetBool("PlayerDid", Playerdie);
            EndGame();
            touchScript.GetComponent<FirstPersonController>().enabled = false;
            cameraColor.SetActive(true);
            weaponDie.SetActive(false);
            fireButton.gameObject.SetActive(false);
            weaponSelectButton.enabled = false;





        }
    }
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene(0);

    }

    IEnumerator playAudioSequentially()
    {
        yield return null;

        //1.Loop through each AudioClip
        for (int i = 0; i < adClips.Length; i++)
        {
            //2.Assign current AudioClip to audiosource
            audioSource.clip = adClips[i];

            //3.Play Audio
            audioSource.Play();

            //4.Wait for it to finish playing
            while (audioSource.isPlaying)
            {
                yield return null;
            }

            //5. Go back to #2 and play the next audio in the adClips array

        }
    }

    public void EndGame()
    {


        StartCoroutine(WaitForSceneLoad());
        StartCoroutine(playAudioSequentially());


    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerHealth.SetHealth(currentHealth);
    }


}









