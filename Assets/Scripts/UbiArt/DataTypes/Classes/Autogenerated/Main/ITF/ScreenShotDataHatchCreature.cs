namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ScreenShotDataHatchCreature : online.OpenGraphObject {
		public string creature_name;
		public string family_name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creature_name = s.Serialize<string>(creature_name, name: "creature_name");
			family_name = s.Serialize<string>(family_name, name: "family_name");
		}
		public override uint? ClassCRC => 0x6295C980;
	}
}

