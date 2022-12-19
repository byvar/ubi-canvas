namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class SequenceTrackInfo_Template : CSerializable {
		public bool isEnable = true;
		public bool selected;
		public bool isGroup;
		public uint parentGroup;
		public string name;
		public bool fold = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isEnable = s.Serialize<bool>(isEnable, name: "isEnable");
			selected = s.Serialize<bool>(selected, name: "selected");
			isGroup = s.Serialize<bool>(isGroup, name: "isGroup");
			parentGroup = s.Serialize<uint>(parentGroup, name: "parentGroup");
			name = s.Serialize<string>(name, name: "name");
			fold = s.Serialize<bool>(fold, name: "fold");
		}
	}
}

