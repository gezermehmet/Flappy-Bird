using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float jumpForce = 9f;
    public GameManager gm;
    public bool isDead;
    public GameObject deathScreen;
    public AudioSource audioSource;
    public AudioClip jumpSound, deathSound, hitSound;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb2d.linearVelocity = Vector2.up * jumpForce;

            if (isDead == false)
            {
                audioSource.PlayOneShot(jumpSound);
            }
            else
            {
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreCollider")
        {
            gm.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "Ground")
        {
            audioSource.PlayOneShot(hitSound);
            audioSource.PlayOneShot(deathSound);
            isDead = true;
            Time.timeScale = 0;


            deathScreen.SetActive(true);
        }
    }
}