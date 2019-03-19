using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CustomAnimComponent : ActorComponent {
		[Serialize("bool__0" )] public bool bool__0;
		[Serialize("float__1")] public float float__1;
		[Serialize("bool__2" )] public bool bool__2;
		[Serialize("float__3")] public float float__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(float__3));
		}
		public override uint? ClassCRC => 0x09FC5C0A;
	}
}

