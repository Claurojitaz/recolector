using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CerezaNaranja : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).transform.localPosition = new Vector3(0.0028f, 0.0105f, -0.0636f);
        GetComponent<XRGrabInteractable>().attachTransform = transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
