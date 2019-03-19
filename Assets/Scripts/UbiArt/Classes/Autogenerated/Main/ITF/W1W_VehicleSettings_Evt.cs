using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_VehicleSettings_Evt : Event {
		[Serialize("bool__0" )] public bool bool__0;
		[Serialize("bool__1" )] public bool bool__1;
		[Serialize("bool__2" )] public bool bool__2;
		[Serialize("bool__3" )] public bool bool__3;
		[Serialize("float__4")] public float float__4;
		[Serialize("float__5")] public float float__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
		}
		public override uint? ClassCRC => 0xBB8AE2FB;
	}
}

