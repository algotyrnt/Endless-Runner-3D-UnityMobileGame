using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Material day;
    public Material night;

    public Material blue;
    public Material red;
    public Material white;
    public Material black;

    public GameObject player;

    private float map;
    private float character;

    public GameObject LoadingScreen;

    void Start()
    {
        LoadingScreen.SetActive(false);
        map = PlayerPrefs.GetFloat("map", map);

        if (map == 1)
        {
            RenderSettings.skybox = night;
        }
        else
        {
            RenderSettings.skybox = day;
        }

        character = PlayerPrefs.GetFloat("character", character);

        if(character == 1)
        {
            player.GetComponent<SkinnedMeshRenderer>().material = black;
        }
        else if(character == 2)
        {
            player.GetComponent<SkinnedMeshRenderer>().material = white;
        }
        else if(character == 3)
        {
            player.GetComponent<SkinnedMeshRenderer>().material = red;
        }
        else
        {
            player.GetComponent<SkinnedMeshRenderer>().material = blue;
        }
    }
}
