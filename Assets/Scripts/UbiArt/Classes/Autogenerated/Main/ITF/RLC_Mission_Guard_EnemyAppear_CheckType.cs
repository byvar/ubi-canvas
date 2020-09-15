using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_EnemyAppear_CheckType : RLC_Mission_Guard {
		public uint appearType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			appearType = s.Serialize<uint>(appearType, name: "appearType");
		}
		public override uint? ClassCRC => 0xC39437B9;
	}
}

