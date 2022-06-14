using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{

    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    public AudioClip itemSound;
    public AudioClip completeSound;

    int itemCount = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreText.text = "Item = " + score.ToString() + "/" + itemCount.ToString();
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Item") //tag.Equals("Item")
        {
            //Delete Item in Scene game
            Destroy(target.gameObject);
            score += 1;
            scoreText.text = "Item = " + score.ToString() + "/" + itemCount.ToString();

            audioSource.PlayOneShot(itemSound);

            if (score >= itemCount)
            {
                audioSource.PlayOneShot(completeSound);

                NextLevel();
            }
            else
            {
                audioSource.PlayOneShot(itemSound);
            }
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }


}
