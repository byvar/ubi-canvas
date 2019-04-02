Shader "Custom/UbiArtAlpha" {
	Properties{
		_Diffuse("Diffuse"             , 2D) = "white" {}
		_BackLight("Back Light"        , 2D) = "white" {}
		_Normal("Normal"               , 2D) = "white" {}
		_SeparateAlpha("Separate Alpha", 2D) = "white" {}
		_Diffuse2("Diffuse 2"          , 2D) = "white" {}
		_BackLight2("Back Light 2"     , 2D) = "white" {}
		_AnimImpostor("Anim Impostor"  , 2D) = "white" {}
		
		_ColorFactor("Color Factor",       Color) = (1,1,1,1)
		_LightConfig("Light Config",      Vector) = (1,1,1,1)
		_ColorFog("Color Fog"      ,       Color) = (1,1,1,1)
		_UseTextures("Use Textures",      Vector) = (0,0,0,0)
		_UseTextures2("Use Textures 2",   Vector) = (0,0,0,0)
		_ShaderParams("Shader params",    Vector) = (1,0,0,0)
		_ShaderParams2("Shader params 2", Vector) = (0,0,0,0)

		_BlendSrc("Blend mode Source",      Float) = 5
		_BlendDst("Blend mode Destination", Float) = 10
	}
	SubShader{
		//ZWrite Off
		Tags{ "Queue" = "Transparent" "RenderType" = "Transparent" }
		Lighting Off

		Pass{
			//Blend SrcAlpha OneMinusSrcAlpha
			Blend [_BlendSrc] [_BlendDst]

			CGPROGRAM

			#pragma vertex vert  
			#pragma fragment frag 
			#pragma multi_compile_fog

			#include "UbiArtShared.cginc"

			v2f vert(appdata_full v) {
				return process_vert(v);
			}
			float4 frag(v2f i) : COLOR {
				clip(_ShaderParams.x-0.5);
				return process_frag(i);
			}
			ENDCG
		}
	}
}