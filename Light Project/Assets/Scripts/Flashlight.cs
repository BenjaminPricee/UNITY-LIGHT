using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light flashlight;
    private bool on;

    private void Start()
    {
        flashlight = GetComponentInChildren<Light>();
        flashlight.gameObject.SetActive(false);
        on = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            FlipSwitch();
        }
    }

    private void FlipSwitch()
    {
        on = !on;
        flashlight.gameObject.SetActive(on);
    }
}
