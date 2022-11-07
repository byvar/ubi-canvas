namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WorldMapUIItem_Template : CSerializable {
		public StringID locationUnlockFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			locationUnlockFX = s.SerializeObject<StringID>(locationUnlockFX, name: "locationUnlockFX");
		}
		public override uint? ClassCRC => 0x2D01A2DC;
	}
}

