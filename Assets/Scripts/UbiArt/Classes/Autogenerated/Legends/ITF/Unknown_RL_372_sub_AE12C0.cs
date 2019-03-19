using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_372_sub_AE12C0 : CSerializable {
		[Serialize("patrol"   )] public int patrol;
		[Serialize("isStatic" )] public int isStatic;
		[Serialize("isInFly"  )] public int isInFly;
		[Serialize("distFront")] public float distFront;
		[Serialize("distBack" )] public float distBack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(patrol));
			SerializeField(s, nameof(isStatic));
			SerializeField(s, nameof(isInFly));
			SerializeField(s, nameof(distFront));
			SerializeField(s, nameof(distBack));
		}
		public override uint? ClassCRC => 0x6C279A69;
	}
}

