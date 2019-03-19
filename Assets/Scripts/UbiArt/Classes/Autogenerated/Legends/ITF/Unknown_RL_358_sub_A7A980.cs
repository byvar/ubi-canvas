using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_358_sub_A7A980 : CSerializable {
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

