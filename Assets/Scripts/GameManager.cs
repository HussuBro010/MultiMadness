using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int index;

    public GameObject[] cars;
    public Transform spawnPoint;

    public CinemachineFreeLook freeLookCam;

    public GameObject pausePanel;
    bool isPaused;

    void Start()
    {
        isPaused = false;
        pausePanel.SetActive(false);

        index = PlayerPrefs.GetInt("carIndex");
        GameObject car = Instantiate(cars[index], spawnPoint.position, Quaternion.identity);
        freeLookCam.Follow = car.transform;
        freeLookCam.LookAt = car.gameObject.transform.GetChild(0).transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

            if (isPaused == true)
            {
                pause();
            }
            else
            {
                resume();
            }
        }
    }

    public void pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
    }

    public void resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.visible = false;
    }
}
