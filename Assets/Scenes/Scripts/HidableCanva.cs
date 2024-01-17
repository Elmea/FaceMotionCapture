using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidableCanva : MonoBehaviour
{
    bool isHidding = false;

    public void Hide()
    {
        if (isHidding)
        {
            isHidding = false;
            this.gameObject.SetActive(true);
            return;
        }

        isHidding = true;
        this.gameObject.SetActive(false);
    }
}
