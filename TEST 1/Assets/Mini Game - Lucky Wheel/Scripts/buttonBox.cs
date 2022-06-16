using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonBox : MonoBehaviour
{ 
    public Slider healthbar;
 
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClick()
    {
        healthbar.value += 20;
        Destroy(button);
    }

}
