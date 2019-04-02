#ifndef SHARED_GOURAUD
#define SHARED_GOURAUD
#include "UnityCG.cginc"

// User-specified properties
uniform float4 _ColorFactor;
uniform float4 _LightConfig;
uniform float4 _ColorFog;
uniform float4 _UseTextures;
uniform float4 _UseTextures2;
uniform float4 _ShaderParams;
uniform float4 _ShaderParams2;

sampler2D _Diffuse;
sampler2D _BackLight;
sampler2D _Normal;
sampler2D _SeparateAlpha;
sampler2D _Diffuse2;
sampler2D _BackLight2;
sampler2D _AnimImpostor; 
uniform float4 _Diffuse_ST;
uniform float4 _BackLight_ST;
uniform float4 _Normal_ST;
uniform float4 _SeparateAlpha_ST;
uniform float4 _Diffuse2_ST;
uniform float4 _BackLight2_ST;
uniform float4 _AnimImpostor_ST;

// Lighting
float _Luminosity = 0.5;
float _Saturate = 1.0;
float _DisableLighting = 0;
float _DisableLightingLocal = 0;
float _DisableFog = 0;

struct v2f {
	float4 pos : SV_POSITION;
	float2 uv1 : TEXCOORD0; // The first UV coordinate.
	float2 uv2 : TEXCOORD1; // The second UV coordinate.
	//UNITY_FOG_COORDS(3)
};

v2f process_vert(appdata_full v) {
	v2f o;
	o.uv1 = TRANSFORM_TEX(v.texcoord.xy, _Diffuse);
	o.uv2 = TRANSFORM_TEX(v.texcoord.xy, _Diffuse);

	/*float4x4 modelMatrix = unity_ObjectToWorld;
	float4x4 modelMatrixInverse = unity_WorldToObject;
	float3 normalDirection, multipliedPosition;*/

	o.pos = UnityObjectToClipPos(v.vertex);
	return o;
}
float4 process_frag(v2f i) : SV_TARGET {
	float4 c = float4(0.0, 0.0, 0.0, 0.0);
	if (_UseTextures.x == 1) {
		float4 texColor = tex2D(_Diffuse, i.uv1);
		c = c + _ColorFactor * texColor;
	}
	return c;
}
#endif // SHARED_GOURAUD