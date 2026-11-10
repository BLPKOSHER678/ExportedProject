Shader "Custom/Jelly2" {
Properties {
 _MainTex ("Texture", 2D) = "white" {}
 _transparency ("Transparency", Range(0,1)) = 0.5
 _brightness ("Brightness", Range(0,1)) = 0.1
 _RimColor ("Rim Color", Color) = (1,1,1,1)
 _RimPower ("Rim Power", Range(0.5,8)) = 3
 _skew ("Skew", Float) = 0
 _skewDir ("skewDir", Vector) = (1,1,1,1)
}
	//DummyShaderTextExporter
	
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Lambert
#pragma target 3.0
		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};
		void surf(Input IN, inout SurfaceOutput o)
		{
			float4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
		}
		ENDCG
	}
}