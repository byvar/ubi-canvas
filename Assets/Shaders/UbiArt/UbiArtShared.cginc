// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

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

sampler2D _LightsBackLight;
sampler2D _LightsFrontLight;
uniform float4 _LightsBackLight_ST;
uniform float4 _LightsFrontLight_ST;

// Lighting
float _Luminosity = 0.5;
float _Saturate = 1.0;
float _EnableLighting = 1;
float _DisableLightingLocal = 0;
float _DisableFog = 0;

struct appdata
{
	float4 vertex    : POSITION;  // The vertex position in model space.
	float3 normal    : NORMAL;    // The vertex normal in model space.
	float4 texcoord  : TEXCOORD0; // The first UV coordinate.
	float4 texcoord1 : TEXCOORD1; // The second UV coordinate.
	float4 texcoord2 : TEXCOORD2; // The third UV coordinate.
	float4 texcoord3 : TEXCOORD3; // The fourth UV coordinate.
	float4 tangent   : TANGENT;   // The tangent vector in Model Space (used for normal mapping).
	float4 color     : COLOR;     // Per-vertex color
};


struct v2f {
	float4 pos : SV_POSITION;
	float2 uv1 : TEXCOORD0; // The first UV coordinate.
	float4 uv2 : TEXCOORD1;
	float4 uv3 : TEXCOORD2;
	float2 uv4 : TEXCOORD3;
	float4 color : COLOR;
	float4 screenPos : TEXCOORD4;
	//UNITY_FOG_COORDS(3)
};

v2f process_vert(appdata v) {
	v2f o;
	o.uv1 = TRANSFORM_TEX(v.texcoord.xy, _Diffuse);
	o.uv2 = v.texcoord1;
	o.uv3 = v.texcoord2;
	o.uv4 = v.texcoord3;
	o.color = v.color;

	/*float4x4 modelMatrix = unity_ObjectToWorld;
	float4x4 modelMatrixInverse = unity_WorldToObject;
	float3 normalDirection, multipliedPosition;*/

	o.pos = UnityObjectToClipPos(v.vertex);
	o.screenPos = ComputeScreenPos(o.pos);
	return o;
}
float4 process_frag(v2f i) : SV_TARGET {
	float4 c = float4(0.0, 0.0, 0.0, 0.0);
	if (_UseTextures.x == 1) {
		float4 texColor = tex2D(_Diffuse, i.uv1);
		c = c + i.color * _ColorFactor * texColor;
		if (_EnableLighting == 1 && _ShaderParams.y == 0 && _ShaderParams.z == 0) {
			float2 screenPos = i.screenPos.xy / i.screenPos.w;
			float4 lightColor = float4(_LightConfig.x, _LightConfig.x, _LightConfig.x, 0) + (tex2D(_LightsFrontLight, screenPos) * _LightConfig.y);
			//c = float4(screenPos.x, screenPos.y, 0, 1);
			c = float4(c.xyz * lightColor.xyz, c.w);
			if (_UseTextures.y == 1) {
				float4 backLightColor = clamp(float4(_LightConfig.z, _LightConfig.z, _LightConfig.z, 0) + tex2D(_LightsBackLight, screenPos) * _LightConfig.w, 0, 1) * tex2D(_BackLight, i.uv1);
				c = c + float4(backLightColor.xyz, 0);
			}
		}
	}
	return c;
}
#endif // SHARED_GOURAUD