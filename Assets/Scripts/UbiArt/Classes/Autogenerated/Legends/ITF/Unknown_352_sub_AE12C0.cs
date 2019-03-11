using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_352_sub_AE12C0 : CSerializable {
		[Serialize("patrol"   )] public bool patrol;
		[Serialize("isStatic" )] public bool isStatic;
		[Serialize("isInFly"  )] public bool isInFly;
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

