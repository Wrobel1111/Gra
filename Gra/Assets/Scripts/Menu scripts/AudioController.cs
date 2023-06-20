using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
	public AudioMixer audioMixer;
	public void SetAudio(float volume)
	{
		audioMixer.SetFloat("Volume", volume);
	}
}
