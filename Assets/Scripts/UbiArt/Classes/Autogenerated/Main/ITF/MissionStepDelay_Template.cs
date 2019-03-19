using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepDelay_Template : CSerializable {
		[Serialize("time")] public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(time));
		}
		public override uint? ClassCRC => 0x3A059B95;
	}
}

