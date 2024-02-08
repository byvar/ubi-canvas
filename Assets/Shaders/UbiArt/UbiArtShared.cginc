// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

#ifndef SHARED_GOURAUD
#define SHARED_GOURAUD
#pragma multi_compile_instancing
#include "UnityCG.cginc"

// User-specified properties
UNITY_INSTANCING_BUFFER_START(Props)
UNITY_DEFINE_INSTANCED_PROP(uniform float4, _ColorFactor); // Primitive Params
UNITY_DEFINE_INSTANCED_PROP(uniform float4, _LightConfig);
UNITY_DEFINE_INSTANCED_PROP(uniform float4, _ColorFog);
UNITY_DEFINE_INSTANCED_PROP(uniform float4, _PrimitiveParams1);

UNITY_DEFINE_INSTANCED_PROP(uniform float4, _UseTextures); // Textures
UNITY_DEFINE_INSTANCED_PROP(uniform float4, _UseTextures2);

UNITY_DEFINE_INSTANCED_PROP(uniform float4, _ShaderParams); // Shader
UNITY_DEFINE_INSTANCED_PROP(uniform float4, _ShaderParams2);
UNITY_INSTANCING_BUFFER_END(Props)

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
float4 _GlobalStaticFog = float4(0,0,0,0);
float4 _GlobalColor = float4(1,1,1,1);
float _EnableGlobalLighting = 0;

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
	UNITY_VERTEX_INPUT_INSTANCE_ID
};


struct v2f {
	float4 pos : SV_POSITION;
	float2 uv1 : TEXCOORD0; // The first UV coordinate.
	float4 uv2 : TEXCOORD1;
	float4 uv3 : TEXCOORD2;
	float2 uv4 : TEXCOORD3;
	float4 color : COLOR;
	float4 screenPos : TEXCOORD4;
	float2 uv1_untransformed : TEXCOORD5;
	UNITY_VERTEX_INPUT_INSTANCE_ID
	//UNITY_FOG_COORDS(3)
};

v2f process_vert(appdata v) {
	v2f o;
	UNITY_SETUP_INSTANCE_ID(v);
	UNITY_TRANSFER_INSTANCE_ID(v, o);
	o.uv1_untransformed = v.texcoord.xy;
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
float4 process_frag(v2f i) : SV_TARGET{
	UNITY_SETUP_INSTANCE_ID(i);
	float4 UseTextures = UNITY_ACCESS_INSTANCED_PROP(Props, _UseTextures);
	float4 UseTextures2 = UNITY_ACCESS_INSTANCED_PROP(Props, _UseTextures2);
	float4 PrimitiveParams1 = UNITY_ACCESS_INSTANCED_PROP(Props, _PrimitiveParams1);

	float4 c = float4(0.0, 0.0, 0.0, 0.0);
	float4 ColorFog = float4(0.0, 0.0, 0.0, 0.0);
	if(PrimitiveParams1.x == 1) { // UseStaticFog
		ColorFog = UNITY_ACCESS_INSTANCED_PROP(Props, _ColorFog);
		if(_EnableGlobalLighting == 1 && PrimitiveParams1.y == 1 && _EnableLighting == 1) { // UseGlobalLighting
			ColorFog = _GlobalStaticFog;
			//ColorFog = float4(lerp(ColorFog.xyz, _GlobalStaticFog.w, _GlobalStaticFog.w);
		}
	}

	if (UseTextures.x == 1) {
		float4 ColorFactor = UNITY_ACCESS_INSTANCED_PROP(Props, _ColorFactor);
		float4 ShaderParams = UNITY_ACCESS_INSTANCED_PROP(Props, _ShaderParams);
		
		if(_EnableGlobalLighting == 1 && PrimitiveParams1.y == 1 && _EnableLighting == 1) { // UseGlobalLighting
			ColorFactor = float4(lerp(ColorFactor.xyz, _GlobalColor.xyz, _GlobalColor.w), ColorFactor.w);
		}

		float4 texColor = tex2D(_Diffuse, i.uv1);
		c = c + i.color * ColorFactor * texColor;

		if(ShaderParams.x == 1) {
			if (_EnableLighting == 1 /*&& ShaderParams.y == 0 && ShaderParams.z == 0*/) {
				float4 backLightTex = float4(0,0,0,0);
				if (UseTextures.y == 1) {
					backLightTex = tex2D(_BackLight, i.uv1);
					backLightTex.w = 0; // TODO: Fix issue where backlight alpha is set to 1 by default if it's missing
				}
				float2 screenPos = i.screenPos.xy / i.screenPos.w;
				float4 LightConfig = UNITY_ACCESS_INSTANCED_PROP(Props, _LightConfig); // Front brightness, front contrast, Back brightness, back contrast
				float3 frontLight = tex2D(_LightsFrontLight, screenPos).xyz * 2;//+ float3(0.5f, 0.5f, 0.5f); //* 2;
				float3 lightColor = float3(LightConfig.x, LightConfig.x, LightConfig.x) // Front brightness
					+ float3(frontLight * LightConfig.y); // Front contrast
				lightColor = lerp(lightColor, float3(1,1,1), float3(backLightTex.w, backLightTex.w, backLightTex.w));
				c = clamp(float4(c.xyz * lightColor, c.w), 0, 1);

				if (UseTextures.y == 1) {
					float3 backLight = tex2D(_LightsBackLight, screenPos).xyz;
					float3 backLightColor = float3(LightConfig.z, LightConfig.z, LightConfig.z) // Back brightness
						+ float3(backLight * LightConfig.w); // Back contrast
					c = clamp(float4(c.xyz + backLightColor.xyz * backLightTex.xyz, c.w), 0, 1);
				}
			}
			if (UseTextures.w == 1) {
				c = float4(c.xyz, c.a * tex2D(_SeparateAlpha, i.uv1_untransformed).a);
			}
		}
	}
	c = lerp(c, float4(ColorFog.xyz, c.w), float4(ColorFog.w, ColorFog.w, ColorFog.w, ColorFog.w));

	return c;
}
#endif // SHARED_GOURAUD