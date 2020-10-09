using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class TriggerSelection_Link : TriggerSelectionAbstract {
		public bool Static;
		public StringID TagName;
		public uint TagValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Static = s.Serialize<bool>(Static, name: "Static");
			TagName = s.SerializeObject<StringID>(TagName, name: "TagName");
			TagValue = s.Serialize<uint>(TagValue, name: "TagValue");
		}
		public override uint? ClassCRC => 0xFF2742F0;
	}
}

