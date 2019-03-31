using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class CatchThemAllComponent : ActorComponent {
		[Serialize("float0")] public float float0;
		[Serialize("float1")] public float float1;
		[Serialize("float2")] public float float2;
		[Serialize("float3")] public float float3;
		[Serialize("float4")] public float float4;
		[Serialize("float5")] public float float5;
		[Serialize("float6")] public float float6;
		[Serialize("float7")] public float float7;
		[Serialize("float8")] public float float8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float0));
			SerializeField(s, nameof(float1));
			SerializeField(s, nameof(float2));
			SerializeField(s, nameof(float3));
			SerializeField(s, nameof(float4));
			SerializeField(s, nameof(float5));
			SerializeField(s, nameof(float6));
			SerializeField(s, nameof(float7));
			SerializeField(s, nameof(float8));
		}
		public override uint? ClassCRC => 0x7EB87D5E;
	}
}