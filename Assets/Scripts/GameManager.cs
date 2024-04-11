using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int index;

    public GameObject[] cars;
    public Transform spawnPoint;

    public CinemachineFreeLook freeLookCam;

    void Start()
    {
        index = PlayerPrefs.GetInt("carIndex");
        GameObject car = Instantiate(cars[index], spawnPoint.position, Quaternion.identity);
        freeLookCam.Follow = car.transform;
        freeLookCam.LookAt = car.gameObject.transform.GetChild(0).transform;
    }
}
