using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour 
{
	public string levelName;

	void OnMouseDown()
	{
		transform.localScale = new Vector3(0.3f,0.3f,1);
	}
	
	void OnMouseUp()
	{
		transform.localScale = new Vector3(0.4f,0.3f,1);

		SceneManager.LoadScene(levelName);
	}
}
