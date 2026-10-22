using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

///<summary>
///<para>Scene:All/NameOfScene/NameOfScene1,NameOfScene2,NameOfScene3...</para>
///<para>Object:N/A</para>
///<para>Description: Sample Description </para>
///</summary>

public class AnimEvents : MonoBehaviour {

	public void LoadScene()
	{
		SceneManager.LoadScene("Loading");
	}

	public void PlayButtonClickSound(bool playButtonSound)
	{
		if (playButtonSound)
			SoundManager.PlaySound("ButtonClick");
	}
}
