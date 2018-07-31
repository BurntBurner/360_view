using UnityEngine;


[ExecuteInEditMode]
public class TestRenderImage : MonoBehaviour {
    public Shader curshader;
    public float grayScaleAmount = 1f;
    private Material curMaterial;

    

    Material material
    {
        get
        {
            if(!curMaterial)
            {
                curMaterial = new Material(curshader);
                curMaterial.hideFlags = HideFlags.HideAndDontSave; 

            }
            return curMaterial;

        }
        

    }

	// Use this for initialization
	void Start () {



		if(!SystemInfo.supportsImageEffects)
        {
            enabled = false;
            return;


        }
        if(!curshader && !curshader.isSupported)
        {
            enabled = false;

        }


    }

    
	
    void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
    {
        if(curshader != null)
        {
            material.SetFloat("_Luminosity", grayScaleAmount);
            Graphics.Blit(sourceTexture, destTexture, material);
        }
        else
        {
            Graphics.Blit(sourceTexture, destTexture);
        }
    }

    void OnDisable()
    {
        if (curMaterial)
        {
            DestroyImmediate(curMaterial);
        }

    }

	// Update is called once per frame
	void Update()
    {
        grayScaleAmount = Mathf.Clamp(grayScaleAmount, 0, 1);	
	}
}
