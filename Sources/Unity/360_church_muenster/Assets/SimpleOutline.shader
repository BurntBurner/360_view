Shader "Holistic/SimpleOutline" {
	
	 Properties {
      _MainTex ("Texture", 2D) = "white" {}
      _MainColor("Color", Color) = (1,1,1,1)
      _OutlineColor ("Outline Color", Color) = (0,0,0,1)
	  _Outline ("Outline Width", Range (.002, 3)) = .005
	  _AlphaFade("AF" , Range (0,1)) = .5
    }
    
   SubShader {
	  Tags {"RenderType"="Transparent" "Queue"="Transparent""IgnoreProjector" = "True"}
   	  ZWrite off
   	
      CGPROGRAM
	      #pragma surface surf Lambert vertex:vert alpha:fade
	      struct Input {
	          float2 uv_MainTex;
	      };
	      float _Outline;
	      float4 _OutlineColor;
	      void vert (inout appdata_full v) {
	          v.vertex.xyz += v.normal * _Outline;
	      }
	      sampler2D _MainTex;
	      void surf (Input IN, inout SurfaceOutput o) 
	      {
	          o.Emission = _OutlineColor.rgb;
	          o.Alpha = _OutlineColor.a;
	          
	      }
      ENDCG
     	
      ZWrite on
   
      CGPROGRAM

          #pragma surface surf Lambert alpha:fade
	      struct Input {
	          float2 uv_MainTex;
	      };

	      fixed4 _MainColor; 
	      sampler2D _MainTex;
	      void surf (Input IN, inout SurfaceOutput o) {

	      		fixed4 col = tex2D(_MainTex, IN.uv_MainTex) * _MainColor;
	        	o.Albedo = col.rgb;
	     	 	o.Alpha = col.a;
	      }
      ENDCG

    } 
    Fallback "Diffuse"
}

