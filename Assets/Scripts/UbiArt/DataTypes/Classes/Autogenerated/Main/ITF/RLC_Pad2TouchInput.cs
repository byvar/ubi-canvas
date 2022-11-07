namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Pad2TouchInput : CSerializable {
		public Enum_InputType InputType;
		public bool forcePosition;
		public Vec2d position;
		public Vec2d offSet;
		public bool swipeRandomDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			InputType = s.Serialize<Enum_InputType>(InputType, name: "InputType");
			forcePosition = s.Serialize<bool>(forcePosition, name: "forcePosition");
			position = s.SerializeObject<Vec2d>(position, name: "position");
			offSet = s.SerializeObject<Vec2d>(offSet, name: "offSet");
			if (s.HasFlags(SerializeFlags.Flags1)) {
				swipeRandomDir = s.Serialize<bool>(swipeRandomDir, name: "swipeRandomDir");
				swipeRandomDir = s.Serialize<bool>(swipeRandomDir, name: "swipeRandomDir");
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

