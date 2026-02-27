// This script demonstrates subscribing/unsubscribing at runtime


using UnityEngine;

public class ListenerToggler : MonoBehaviour
{
    private bool isSoundEnabled = true;
    private SoundListener soundListener;

    private void Start()
    {
        soundListener = FindObjectOfType<SoundListener>();
        Debug.Log("[Toggler] Press M to toggle sound listener on/off");
        Debug.Log("[Toggler] Press K to kill enemy");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (soundListener != null)
            {
                isSoundEnabled = !isSoundEnabled;
                soundListener.enabled = isSoundEnabled;

                if (isSoundEnabled)
                {
                    Debug.Log("[Toggler] Sound listener turned ON (radio on)");
                }
                else
                {
                    Debug.Log("[Toggler] Sound listener turned OFF (radio off)");
                }
            }
        }
    }
}
