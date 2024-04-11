using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    public GameObject[] cars;

    public Button next;
    public Button previous;

    int index;

    void Start()
    {
        index = PlayerPrefs.GetInt("carIndex");

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= cars.Length-1)
        {
            next.interactable = false;
        }
        else
        {
            next.interactable = true;
        }

        if (index <= 0)
        {
            previous.interactable = false;
        }
        else
        {
            previous.interactable = true;
        }
    }

    public void Next()
    {
        index++;

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }

        PlayerPrefs.SetInt("carIndex", index);
        PlayerPrefs.Save();
    }
    public void Prev()
    {
        index--;

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }

        PlayerPrefs.SetInt("carIndex", index);
        PlayerPrefs.Save();
    }

    public void race()
    {
        SceneManager.LoadSceneAsync("Test");
    }
}
