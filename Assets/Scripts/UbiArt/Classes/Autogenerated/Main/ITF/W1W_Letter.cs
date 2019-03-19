using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Letter : W1W_InteractiveGenComponent {
		[Serialize("bool__0"          )] public bool bool__0;
		[Serialize("StringID__1"      )] public StringID StringID__1;
		[Serialize("uint__2"          )] public uint uint__2;
		[Serialize("uint__3"          )] public uint uint__3;
		[Serialize("uint__4"          )] public uint uint__4;
		[Serialize("bool__5"          )] public bool bool__5;
		[Serialize("float__6"         )] public float float__6;
		[Serialize("float__7"         )] public float float__7;
		[Serialize("LocalisationId__8")] public LocalisationId LocalisationId__8;
		[Serialize("LocalisationId__9")] public LocalisationId LocalisationId__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(uint__2));
			SerializeField(s, nameof(uint__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(bool__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(LocalisationId__8));
				SerializeField(s, nameof(LocalisationId__9));
			}
		}
		public override uint? ClassCRC => 0x4D192E6A;
	}
}

