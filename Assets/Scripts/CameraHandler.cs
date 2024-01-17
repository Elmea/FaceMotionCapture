using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] Material camMaterial;
    [SerializeField] TMPro.TMP_Dropdown devicesDropdown;
    WebCamDevice[] devices;
    List<string> devicesNames;

    WebCamDevice? selectedDevice;
    WebCamTexture webCamTexture;

    // Start is called before the first frame update
    void Start()
    {
        devices = WebCamTexture.devices;
        devicesNames = new List<string>();
        devicesNames.Add("None");
        for (var i = 0; i < devices.Length; i++)
        {
            devicesNames.Add(devices[i].name);
            Debug.Log(devices[i].name);
        }

        selectedDevice = null;

        devicesDropdown.ClearOptions();
        devicesDropdown.AddOptions(devicesNames);
        webCamTexture = new WebCamTexture();
    }

    public void DevicesChanged()
    {
        if (webCamTexture.isPlaying)
            webCamTexture.Stop();

        if (devicesDropdown.value == 0)
        {
            selectedDevice = null;
            return;
        }

        selectedDevice = devices[devicesDropdown.value - 1];
        webCamTexture = new WebCamTexture(selectedDevice.Value.name);
        webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedDevice != null)
        {
            Debug.Log(selectedDevice.Value.name);
            camMaterial.mainTexture = webCamTexture;
        }
    }
}
