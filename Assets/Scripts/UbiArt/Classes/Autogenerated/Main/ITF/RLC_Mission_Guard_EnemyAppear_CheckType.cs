using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_EnemyAppear_CheckType : RLC_Mission_Guard {
		[Serialize("appearType")] public uint appearType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(appearType));
		}
		public override uint? ClassCRC => 0xC39437B9;
	}
}

