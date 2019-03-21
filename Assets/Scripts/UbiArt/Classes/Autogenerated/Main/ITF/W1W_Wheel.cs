using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Wheel : W1W_InteractiveGenComponent {
		[Serialize("bool__0"  )] public bool bool__0;
		[Serialize("bool__1"  )] public bool bool__1;
		[Serialize("bool__2"  )] public bool bool__2;
		[Serialize("bool__3"  )] public bool bool__3;
		[Serialize("bool__4"  )] public bool bool__4;
		[Serialize("float__5" )] public float float__5;
		[Serialize("float__6" )] public float float__6;
		[Serialize("float__7" )] public float float__7;
		[Serialize("float__8" )] public float float__8;
		[Serialize("float__9" )] public float float__9;
		[Serialize("uint__10" )] public uint uint__10;
		[Serialize("float__11")] public float float__11_;
		[Serialize("bool__12" )] public bool bool__12;
		[Serialize("float__13")] public float float__13_;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(uint__10));
				SerializeField(s, nameof(float__11_));
				SerializeField(s, nameof(bool__12));
				SerializeField(s, nameof(float__13_));
			}
		}
		public override uint? ClassCRC => 0x9B0058FF;
	}
}

