namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class BTActionOnComponentStateSetFact_Template : BTAction_Template {
		public StringID fact;
		public uint ComponentList;
		public uint StateList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fact = s.SerializeObject<StringID>(fact, name: "fact");
			if (s.HasFlags(SerializeFlags.Editor)) {
				ComponentList = s.SerializeChoiceList<uint>(ComponentList, name: "ComponentList", empty: "Invalid");
				StateList = s.SerializeChoiceList<uint>(StateList, name: "StateList"); // No empty for this
			} else {
				ComponentList = s.Serialize<uint>(ComponentList, name: "ComponentList");
				StateList = s.Serialize<uint>(StateList, name: "StateList");
			}
		}
		public override uint? ClassCRC => 0x8D9BD77F;
	}
}

