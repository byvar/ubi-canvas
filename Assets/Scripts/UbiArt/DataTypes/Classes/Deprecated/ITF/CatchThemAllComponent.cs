namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class CatchThemAllComponent : ActorComponent {
		public float float0;
		public float float1;
		public float float2;
		public float float3;
		public float float4;
		public float float5;
		public float float6;
		public float float7;
		public float float8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float0 = s.Serialize<float>(float0, name: "float0");
			float1 = s.Serialize<float>(float1, name: "float1");
			float2 = s.Serialize<float>(float2, name: "float2");
			float3 = s.Serialize<float>(float3, name: "float3");
			float4 = s.Serialize<float>(float4, name: "float4");
			float5 = s.Serialize<float>(float5, name: "float5");
			float6 = s.Serialize<float>(float6, name: "float6");
			float7 = s.Serialize<float>(float7, name: "float7");
			float8 = s.Serialize<float>(float8, name: "float8");
		}
		public override uint? ClassCRC => 0x7EB87D5E;
	}
}
