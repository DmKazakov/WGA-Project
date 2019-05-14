using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoaderActive : MonoBehaviour {
	private PlayerKeyboardController thePlayer;

	public string sceneToLoad;
	public string exitPoint;
    public bool isOpen;

    public GameObject writePressE;
    public GameObject writeClosed;

    bool colliding;

    private void Start() {
		thePlayer = FindObjectOfType<PlayerKeyboardController>();
	}


    void Update()
    {
        if (colliding && Input.GetKeyDown(KeyCode.E) && isOpen)
        {
            SceneManager.LoadScene(sceneToLoad);
            thePlayer.statrtPoint = exitPoint;
        }
    }

	void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            colliding = true;

            if (isOpen)
            {
                writePressE.SetActive(true);
            }
            else
                writeClosed.SetActive(true);
        }
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        colliding = false;

        if (isOpen)
        {
            writePressE.SetActive(false);
        }
        else
            writeClosed.SetActive(false);
    }
}
