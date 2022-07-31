using UnityEngine;


public class Fire : MonoBehaviour
{
	float _time;

	void OnEnable () //활성화가 될때
	{
		//Time.time은 게임을 시작하고 얼마나 지났지에 대한 시간.
		_time = Time.time + 0.3f;
	}
	
	// FixedUpdate는 우리가 정한 시간마다 0.02f
	void FixedUpdate () 
	{
		if (_time < Time.time)
		 gameObject.SetActive(false);
	}
}
