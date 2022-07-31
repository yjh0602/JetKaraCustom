using UnityEngine;

public class AudioController : MonoBehaviour
{
	public Sprite on;
	public Sprite off;
	
	SpriteRenderer sp;
	
	void Awake () //start보다 awake가 더 빠르게 처리된다.
	{
		sp = GetComponent<SpriteRenderer>(); //미리 넣어두는 캐싱
		
		if (PlayerPrefs.GetInt("Mute",0) == 1)
		{
			AudioListener.volume = 0;
			sp.sprite = off;
		}
		else
		{
			AudioListener.volume = 1;
			sp.sprite = on;
		}
	}
	
	//콜라이더가 있어야한다.
	void OnMouseDown()
	{
		transform.localScale = new Vector3(0.9f,0.9f,1);
	}
	
	void OnMouseUp()
	{
		transform.localScale = new Vector3(1,1,1);
		
		if (PlayerPrefs.GetInt("Mute",0) == 0)
		{
			AudioListener.volume = 0;
			PlayerPrefs.SetInt("Mute",1);
			sp.sprite = off;
		}
		else
		{
			AudioListener.volume = 1;
			PlayerPrefs.SetInt("Mute",0);
			sp.sprite = on;
		}
		
		PlayerPrefs.Save();
	}
}
