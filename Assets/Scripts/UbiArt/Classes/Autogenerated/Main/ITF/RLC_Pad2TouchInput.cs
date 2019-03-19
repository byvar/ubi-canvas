using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Pad2TouchInput : CSerializable {
		[Serialize("InputType"     )] public Enum_InputType InputType;
		[Serialize("forcePosition" )] public bool forcePosition;
		[Serialize("position"      )] public Vector2 position;
		[Serialize("offSet"        )] public Vector2 offSet;
		[Serialize("swipeRandomDir")] public bool swipeRandomDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(InputType));
			SerializeField(s, nameof(forcePosition));
			SerializeField(s, nameof(position));
			SerializeField(s, nameof(offSet));
			if (s.HasFlags(SerializeFlags.Flags1)) {
				SerializeField(s, nameof(swipeRandomDir));
				SerializeField(s, nameof(swipeRandomDir));
			}
		}
		public enum Enum_InputType {
			[Serialize("Unknown")] Unknown = 0,
			[Serialize("Contact")] Contact = 1,
			[Serialize("Hold"   )] Hold = 2,
			[Serialize("Swipe"  )] Swipe = 3,
		}
		public override uint? ClassCRC => 0x37BFBA98;
	}
}

