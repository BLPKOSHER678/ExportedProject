Shader "Custom/Jelly Detail" {
Properties {
 _MainTex ("Texture", 2D) = "white" {}
 _brightness ("Brightness", Range(0,1)) = 0.1
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