using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_StargateComponent_Template : CSerializable {
		[Serialize("speed"       )] public float speed;
		[Serialize("boneStart"   )] public StringID boneStart;
		[Serialize("teleportArea")] public StringID teleportArea;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(boneStart));
			SerializeField(s, nameof(teleportArea));
		}
		public override uint? ClassCRC => 0xB26BD4F9;
	}
}

