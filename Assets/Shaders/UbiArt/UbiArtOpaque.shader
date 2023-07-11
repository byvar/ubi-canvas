Shader "Custom/UbiArtOpaque" {
	Properties{
		[PerRendererData] _Diffuse("Diffuse"             , 2D) = "white" {}
		[PerRendererData] _BackLight("Back Light"        , 2D) = "white" {}
		[PerRendererData] _Normal("Normal"               , 2D) = "white" {}
		[PerRendererData] _SeparateAlpha("Separate Alpha", 2D) = "white" {}
		[PerRendererData] _Diffuse2("Diffuse 2"          , 2D) = "white" {}
		[PerRendererData] _BackLight2("Back Light 2"     , 2D) = "white" {}
		[PerRendererData] _AnimImpostor("Anim Impostor"  , 2D) = "white" {}

		[PerRendererData] _ColorFactor("Color Factor",       Color) = (1,1,1,1)
		[PerRendererData] _LightConfig("Light Config",      Vector) = (0,1,0,1)
		[PerRendererData] _ColorFog("Color Fog",             Color) = (1,1,1,1)
		[PerRendererData] _UseTextures("Use Textures",      Vector) = (0,0,0,0)
		[PerRendererData] _UseTextures2("Use Textures 2",   Vector) = (0,0,0,0)
		[PerRendererData] _ShaderParams("Shader params",    Vector) = (1,0,0,0)
		[PerRendererData] _ShaderParams2("Shader params 2", Vector) = (0,0,0,0)

		_BlendSrc("Blend mode Source",      Float) = 5
		_BlendDst("Blend mode Destination", Float) = 10
		[Enum(Off,0,On,1)] _ZWrite("ZWrite",  Int) = 1
	}
		SubShader{
			//ZWrite [_ZWrite]
			Tags{ "RenderType" = "Opaque" }
			Lighting Off

			Pass{
				//Blend SrcAlpha OneMinusSrcAlpha
				Blend[_BlendSrc][_BlendDst]

				CGPROGRAM

				#pragma vertex vert  
				#pragma fragment frag 
				#pragma multi_compile_fog

				#include "UbiArtShared.cginc"

				v2f vert(appdata v) {
					return process_vert(v);
				}
				float4 frag(v2f i) : COLOR {
					//clip(_ShaderParams.x-0.5);
					return process_frag(i);
				}
				ENDCG
			}
		}
}