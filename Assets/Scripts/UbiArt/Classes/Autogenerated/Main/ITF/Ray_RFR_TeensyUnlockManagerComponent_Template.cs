using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_TeensyUnlockManagerComponent_Template : Ray_AIComponent_Template {
		[Serialize("Path__0" )] public Path Path__0;
		[Serialize("uint__1" )] public uint uint__1;
		[Serialize("float__2")] public float float__2;
		[Serialize("float__3")] public float float__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
		}
		public override uint? ClassCRC => 0x1776BC3E;
	}
}

