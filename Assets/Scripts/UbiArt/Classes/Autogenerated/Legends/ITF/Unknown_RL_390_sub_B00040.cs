using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_390_sub_B00040 : CSerializable {
		[Serialize("hideDistance")] public float hideDistance;
		[Serialize("waitDistance")] public float waitDistance;
		[Serialize("hysteresis"  )] public float hysteresis;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hideDistance));
			SerializeField(s, nameof(waitDistance));
			SerializeField(s, nameof(hysteresis));
		}
		public override uint? ClassCRC => 0x960CE735;
	}
}

