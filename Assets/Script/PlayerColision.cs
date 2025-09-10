using Unity.VisualScripting;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    // public PlayerScript playerScript;
    public Animator playerAnimator;
    public Player playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    // private void OnCollisionEnter(Collision other)
    // {
    //     Debug.Log(other.gameObject.name);
    //     if (other.gameObject.tag == "Collectable")
    //     {
    //         Destroy(other.gameObject);
    //     }
    // }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            gameController.GameOver();
            playerScript.enabled = false;
            playerAnimator.SetBool("isRuning", false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
    }
}