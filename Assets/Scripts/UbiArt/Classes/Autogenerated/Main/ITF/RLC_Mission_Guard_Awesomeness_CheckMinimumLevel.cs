using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_Mission_Guard_Awesomeness_CheckMinimumLevel : CSerializable {
		public uint minimumLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minimumLevel = s.Serialize<uint>(minimumLevel, name: "minimumLevel");
		}
		public override uint? ClassCRC => 0xCDE8F93C;
	}
}

