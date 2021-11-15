using UnityEngine;
using System.Collections;

public class SantaController : MonoBehaviour
{

    public float flyPower = 30;

    public AudioClip flyClip;
    public AudioClip gameOverClip;

    private AudioSource audioSource;

    GameObject obj;
    GameObject gameController;
    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;

        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if(!gameController.GetComponent<GameController>().isEndGame)
                audioSource.Play();
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        gameController.GetComponent<GameController>().GetPoint();

    }
    void EndGame()
    {
        audioSource.clip = gameOverClip;
        audioSource.Stop();
        gameController.GetComponent<GameController>().EndGame();
    }
}
