using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void Update ()
	{
        if (Input.touchCount > 0 )
        {
            GameManager.instance.Restart();
        }

        GetComponent<RectTransform>().localScale = Vector3.one * 2;//Planet.Size;
	}

	public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

}
