using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessController : MonoBehaviour
{
    PostProcessVolume postProcessVolume;
    Vignette vignette;
    private FloatParameter _intensity = new FloatParameter
    {
        value = .5f
    };
    public ColorParameter color = new ColorParameter
    {
        value = new Color(255f, 0f, 0f, 1f)
    };
    void Start()
    {
        postProcessVolume = GetComponent<PostProcessVolume>();
        postProcessVolume.profile.TryGetSettings (out vignette);
        vignette.enabled.Override(true);
        vignette.intensity.Override(_intensity);
        vignette.color.Override(Color.red);
        StartCoroutine(blinkVignette());
    }

    //private IEnumerator blinkVignette()
    //{
    //    vignette.intensity.Override(_intensity);
    //    yield return new WaitForSeconds(.5f);
    //    vignette.intensity.Override(_intensity/1.2f);
    //    yield return new WaitForSeconds(.5f);
    //    StartCoroutine(blinkVignette());
    //    Debug.Log("opa");
    //}
    private IEnumerator blinkVignette()
    {
        vignette.active = false;
        yield return new WaitForSeconds(1);
        vignette.active = true;
        yield return new WaitForSeconds(1);
        StartCoroutine(blinkVignette());
        Debug.Log("opa");
    }
}
