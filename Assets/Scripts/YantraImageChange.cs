using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YantraImageChange : MonoBehaviour
{
    public Texture Image01;
    public Texture Image02;
    public Texture Image03;
    public Texture Image04;
    Renderer mRenderer;
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<Renderer>();
        Image01 = Resources.Load<Texture>("Images/Yantra1") as Texture;
        Image02 = Resources.Load<Texture>("Images/Yantra2") as Texture;
        Image03 = Resources.Load<Texture>("Images/Yantra3") as Texture;
        Image04 = Resources.Load<Texture>("Images/Yantra4") as Texture;
        mRenderer.material.mainTexture = Image01;
        mRenderer.material.EnableKeyword("_EMISSIONMAP");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            count = count + 1;

            if (count > 5)
            {
                count = 1;
            }


        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            count = count - 1;
            if (count < 1)
            {
                count = 4;
            }

        }
        switch (count)
        {
            case 1:
                mRenderer.material.mainTexture = Image01;
                mRenderer.material.SetTexture("_EmissionMap", Image01);
                break;

            case 2:
                mRenderer.material.mainTexture = Image02;
                mRenderer.material.SetTexture("_EmissionMap", Image02);
                break;
            case 3:
                mRenderer.material.mainTexture = Image03;
                mRenderer.material.SetTexture("_EmissionMap", Image03);
                break;

            case 4:
                mRenderer.material.mainTexture = Image04;
                mRenderer.material.SetTexture("_EmissionMap", Image04);
                break;


        }

    }
}
