using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TimeAttackFlagComponent_Template : CSerializable {
		[Serialize("waitTime")] public float waitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitTime));
		}
		public override uint? ClassCRC => 0x96013423;
	}
}

