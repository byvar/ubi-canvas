namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ScreenShotDataCostumeShowcase : online.OpenGraphObject {
		public string costumeName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumeName = s.Serialize<string>(costumeName, name: "costumeName");
		}
		public override uint? ClassCRC => 0x16DA3177;
	}
}

