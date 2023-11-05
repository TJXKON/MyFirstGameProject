using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlashController : MonoBehaviour
{   
    public Material flashMaterial;
    [SerializeField] private float duration = 0.3f;
    private Image image;
    private Material originalMaterial;
    private Coroutine flashRoutine;
    // Start is called before the first frame update
    void Start() {
        image = GetComponent<Image>();
        originalMaterial = image.material;
    }
    public void Flash(){
        if(flashRoutine!=null){
            StopCoroutine(flashRoutine);
        }
        flashRoutine = StartCoroutine(FlashRoutine());
    }
    private IEnumerator FlashRoutine(){
        image.material = flashMaterial;
        yield return new WaitForSeconds(duration);
        image.material = originalMaterial;
        flashRoutine = null;
    }
}
