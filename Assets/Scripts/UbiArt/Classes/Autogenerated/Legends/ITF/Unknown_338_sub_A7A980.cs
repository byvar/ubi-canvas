using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_338_sub_A7A980 : CSerializable {
		[Serialize("tapAccelerationMultiplier")] public float tapAccelerationMultiplier;
		[Serialize("gettimePlayRate"          )] public float gettimePlayRate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tapAccelerationMultiplier));
			SerializeField(s, nameof(gettimePlayRate));
		}
		public override uint? ClassCRC => 0x38A31802;
	}
}

