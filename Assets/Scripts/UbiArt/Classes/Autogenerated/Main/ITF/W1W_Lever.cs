using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Lever : W1W_InteractiveGenComponent {
		[Serialize("bool__0" )] public bool bool__0;
		[Serialize("bool__1" )] public bool bool__1;
		[Serialize("bool__2" )] public bool bool__2;
		[Serialize("bool__3" )] public bool bool__3;
		[Serialize("float__4")] public float float__4;
		[Serialize("bool__5" )] public bool bool__5;
		[Serialize("float__6")] public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(float__6));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(bool__0));
			}
		}
		public override uint? ClassCRC => 0x86E8F84E;
	}
}

