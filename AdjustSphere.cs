using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustSphere : MonoBehaviour
{
    public Slider ScaleSlider;

    [SerializeField] float currentScale = 1f;

    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
    }

    private void OnGUI()
    {
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    public void AdjustScale(float newScale)
    {

    }
}