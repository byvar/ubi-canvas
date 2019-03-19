using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class RJR_Config_Template : CSerializable {
		[Serialize("uint__0"            )] public uint uint__0;
		[Serialize("CList<WorldInfo>__1")] public CList<WorldInfo> CList_WorldInfo__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(CList_WorldInfo__1));
		}
		public override uint? ClassCRC => 0xF54D1A73;
	}
}

