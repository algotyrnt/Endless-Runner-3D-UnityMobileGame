using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
	public GameObject Countdown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject CountDownP;
	public AudioSource LevelMusic;
	public bool countdown;
	PlayerMovement playerMovement;
	ScoreSystem score;
	[SerializeField] private GameObject player;
	public GameObject manager;

	void Start()
	{
		Time.timeScale = 1;
		countdown = (false);
		score = manager.GetComponent<ScoreSystem>();
		score.enabled = (false);
		playerMovement = player.GetComponent<PlayerMovement>();
		playerMovement.enabled = (false);
		CountDownP.SetActive(true);
		StartCoroutine(CountStart());
	}

	IEnumerator CountStart()
	{
		yield return new WaitForSeconds(0.5f);
		Countdown.GetComponent<Text>().text = "3";
		GetReady.Play();
		Countdown.SetActive(true);
		yield return new WaitForSeconds(1);
		Countdown.SetActive(false);
		
		Countdown.GetComponent<Text>().text = "2";
		GetReady.Play();
		Countdown.SetActive(true);
		yield return new WaitForSeconds(1);
		Countdown.SetActive(false);
		
		Countdown.GetComponent<Text>().text = "1";
		GetReady.Play();
		Countdown.SetActive(true);
		yield return new WaitForSeconds(1);
		Countdown.SetActive(false);

		Countdown.GetComponent<Text>().text = "GO";
		GetReady.Play();
		Countdown.SetActive(true);
		yield return new WaitForSeconds(0);
		Countdown.SetActive(false);

		GoAudio.Play();
		LevelMusic.Play();
		CountDownP.SetActive(false);
		playerMovement.enabled = (true);
		score.enabled = (true);
	}


}