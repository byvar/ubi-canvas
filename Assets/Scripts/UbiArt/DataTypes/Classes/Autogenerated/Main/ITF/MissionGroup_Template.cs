namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionGroup_Template : CSerializable {
		public PathRef cheatMapPath;
		public bool concurrent;
		public bool pickOneAfterBattle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cheatMapPath = s.SerializeObject<PathRef>(cheatMapPath, name: "cheatMapPath");
			concurrent = s.Serialize<bool>(concurrent, name: "concurrent", options: CSerializerObject.Options.BoolAsByte);
			pickOneAfterBattle = s.Serialize<bool>(pickOneAfterBattle, name: "pickOneAfterBattle", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x2DB01F12;
	}
}

