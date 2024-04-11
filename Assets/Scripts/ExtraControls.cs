using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraControls : MonoBehaviour
{
    [SerializeField] Light leftHeadLight;
    [SerializeField] Light rightHeadLight;
    bool headlightsOn = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        leftHeadLight.enabled = false;
        rightHeadLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            headlightsOn = !headlightsOn;
            Debug.Log("ON!!");
            headlights(headlightsOn);
        }
    }

    public void headlights(bool state)
    {
        leftHeadLight.enabled = state;
        rightHeadLight.enabled = state;
    }
}
