using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	bool dead;
	public AudioClip[] auClip;
	public GameObject fire;

	void Start()
	{
		dead = false;
		GetComponent<AudioSource>().clip = auClip[0];
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !dead)
		{					
				Jump();			
		}
	}

	void Jump()
	{
		//SetActive(bool) 게임 오브젝트의 활성화 / 비활성화 
		fire.SetActive (true);
		GetComponent<AudioSource>().clip = auClip[0];
		GetComponent<AudioSource>().Play();
		GetComponent<Rigidbody2D>().velocity = Vector2.zero; // 점프하기전에 일단 속도를 0 으로 만든다. 중력가속도 순간 0으로.

		GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
	}

	void OnTriggerEnter2D(Collider2D col) 
	{
		if (!dead)
		{
			if (col.tag == "Score")
			{
				GetComponent<AudioSource>().clip = auClip[1];
				GetComponent<AudioSource>().Play();
				GameObject.FindObjectOfType<GameManager>().Score++;
				Destroy(col.gameObject); // 더이상 점수가 추가 안되도록 없엔다.
			}
			else if (col.tag == "Finish")
			{
				GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
				dead = true;
				GetComponent<AudioSource>().clip = auClip[2]; // 다른 오디오소스를 소환한다.
				GetComponent<AudioSource>().Play(); // 오디오소스를 플레이
				Invoke("BackToMain", 1.5f); // 메뉴로 1.5 초 뒤에 간다.
			}
		}
	}

	void BackToMain()
	{
        SceneManager.LoadScene("MainMenu");
	}
}
