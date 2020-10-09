using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CreatureWH_BulbComponent : RO2_AIComponent {
		public bool onlyAttackInWater;
		public bool dieOnTrigger;
		public bool retractOnTrigger;
		public bool isDead;
		public CListO<RO2_CreatureWH_BulbComponent.HandSlot> slots;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				onlyAttackInWater = s.Serialize<bool>(onlyAttackInWater, name: "onlyAttackInWater");
				dieOnTrigger = s.Serialize<bool>(dieOnTrigger, name: "dieOnTrigger");
				retractOnTrigger = s.Serialize<bool>(retractOnTrigger, name: "retractOnTrigger");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				isDead = s.Serialize<bool>(isDead, name: "isDead");
				slots = s.SerializeObject<CListO<RO2_CreatureWH_BulbComponent.HandSlot>>(slots, name: "slots");
			}
		}
		[Games(GameFlags.RA)]
		public partial class HandSlot : CSerializable {
			public uint ckp_state;
			public Vec2d ckp_pos;
			public float ckp_branchCursor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				ckp_state = s.Serialize<uint>(ckp_state, name: "ckp_state");
				ckp_pos = s.SerializeObject<Vec2d>(ckp_pos, name: "ckp_pos");
				ckp_branchCursor = s.Serialize<float>(ckp_branchCursor, name: "ckp_branchCursor");
			}
		}
		public override uint? ClassCRC => 0x7CCD1F01;
	}
}

