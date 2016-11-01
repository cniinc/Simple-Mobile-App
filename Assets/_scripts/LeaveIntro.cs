using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LeaveIntro : MonoBehaviour {
	[SerializeField] float loadLength;

	// Use this for initialization
	void Start () {
		StartCoroutine (LoadTransition ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private IEnumerator LoadTransition()
	{
		yield return new WaitForSeconds (loadLength);

		SceneManager.LoadScene (1);
	}
}
