using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonDisplay : MonoBehaviour
{
    public Image image;
    Color color;
    // Start is called before the first frame update
    void Start()
    {
        color = image.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.GetComponent<Button>().enabled == false){
            color.a=0.25f;
        }else{
            color.a=1f;

        }
        image.color = color;
    }
}
