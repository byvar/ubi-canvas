using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_ItemComponent : ActorComponent {
		[Serialize("int__0" )] public int int__0;
		[Serialize("int__1" )] public int int__1;
		[Serialize("bool__2")] public bool bool__2;
		[Serialize("int__3" )] public int int__3;
		[Serialize("uint__4")] public uint uint__4;
		[Serialize("int__5" )] public int int__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
			SerializeField(s, nameof(int__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(int__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(int__5));
		}
		public override uint? ClassCRC => 0x420B2AEB;
	}
}

