using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ActivationSequenceStoneComponent_Template : CSerializable {
		[Serialize("fx"            )] public Path fx;
		[Serialize("fxBone"        )] public StringID fxBone;
		[Serialize("activationTime")] public float activationTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(fxBone));
			SerializeField(s, nameof(activationTime));
		}
		public override uint? ClassCRC => 0x7007EA49;
	}
}

