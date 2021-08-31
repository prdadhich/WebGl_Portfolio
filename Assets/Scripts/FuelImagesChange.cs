using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelImagesChange : MonoBehaviour
{
    public Texture Image01;
    public Texture Image02;
    Renderer mRenderer;
    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<Renderer>();
        Image01 = Resources.Load<Texture>("Images/TeamSanofiGenzyme_A4_Page_1") as Texture;
        Image02 = Resources.Load<Texture>("Images/TeamSanofiGenzyme_A4_Page_2") as Texture;
        mRenderer.material.mainTexture = Image01;
        mRenderer.material.EnableKeyword("_EMISSIONMAP");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            mRenderer.material.mainTexture = Image02;
            mRenderer.material.SetTexture("_EmissionMap", Image02);
        
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            mRenderer.material.mainTexture = Image01;
            mRenderer.material.SetTexture("_EmissionMap", Image01);
        }

    }
}
