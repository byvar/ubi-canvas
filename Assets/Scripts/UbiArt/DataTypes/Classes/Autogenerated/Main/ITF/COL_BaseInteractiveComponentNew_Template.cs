namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BaseInteractiveComponentNew_Template : CSerializable {
		public float interactButtonYOffset;
		public float interactButtonZOffsetFromAurora;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			interactButtonYOffset = s.Serialize<float>(interactButtonYOffset, name: "interactButtonYOffset");
			interactButtonZOffsetFromAurora = s.Serialize<float>(interactButtonZOffsetFromAurora, name: "interactButtonZOffsetFromAurora");
		}
		public override uint? ClassCRC => 0x2F875501;
	}
}

