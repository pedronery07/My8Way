using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    AudioSource[] audios;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audios = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
    	if (other.tag == "Coletável")
    	{
    	  audios[0].Play();
    	  GameController.Collect();
	  Destroy(other.gameObject);
    	}
    	if (other.tag == "Inimigo")
    	{
    	  audios[1].Play();
    	  GameController.Die();
    	}
    }
}
