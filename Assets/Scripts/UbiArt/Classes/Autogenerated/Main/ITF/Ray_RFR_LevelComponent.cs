using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_LevelComponent : ActorComponent {
		[Serialize("uint__0")] public uint uint__0;
		[Serialize("uint__1")] public uint uint__1;
		[Serialize("uint__2")] public uint uint__2;
		[Serialize("int__3" )] public int int__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(uint__2));
			SerializeField(s, nameof(int__3));
		}
		public override uint? ClassCRC => 0x995963EC;
	}
}

