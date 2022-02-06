using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    [SerializeField] private InputField InputName;
    [SerializeField] private Text Textname;
    [SerializeField] private GameObject PanelName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void SetName()
    {
        PanelName.SetActive(false);
        Textname.text += " " + InputName.text;
    }
}
