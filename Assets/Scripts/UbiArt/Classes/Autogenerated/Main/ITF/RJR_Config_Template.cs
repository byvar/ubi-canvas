using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class RJR_Config_Template : CSerializable {
		public uint uint__0;
		public CList<WorldInfo> CList_WorldInfo__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			CList_WorldInfo__1 = s.SerializeObject<CList<WorldInfo>>(CList_WorldInfo__1, name: "CList_WorldInfo__1");
		}
		public override uint? ClassCRC => 0xF54D1A73;
	}
}

