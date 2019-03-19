using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_LeaderboardComponent_Template : CSerializable {
		[Serialize("int__0" )] public int int__0;
		[Serialize("uint__1")] public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
			SerializeField(s, nameof(uint__1));
		}
		public override uint? ClassCRC => 0x2B458C21;
	}
}

