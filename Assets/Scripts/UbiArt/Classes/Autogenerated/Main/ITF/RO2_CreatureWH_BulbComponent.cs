using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CreatureWH_BulbComponent : RO2_AIComponent {
		[Serialize("onlyAttackInWater")] public bool onlyAttackInWater;
		[Serialize("dieOnTrigger"     )] public bool dieOnTrigger;
		[Serialize("retractOnTrigger" )] public bool retractOnTrigger;
		[Serialize("isDead"           )] public bool isDead;
		[Serialize("slots"            )] public CList<RO2_CreatureWH_BulbComponent.HandSlot> slots;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(onlyAttackInWater));
				SerializeField(s, nameof(dieOnTrigger));
				SerializeField(s, nameof(retractOnTrigger));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isDead));
				SerializeField(s, nameof(slots));
			}
		}
		[Games(GameFlags.RA)]
		public partial class HandSlot : CSerializable {
			[Serialize("ckp_state"       )] public uint ckp_state;
			[Serialize("ckp_pos"         )] public Vector2 ckp_pos;
			[Serialize("ckp_branchCursor")] public float ckp_branchCursor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(ckp_state));
				SerializeField(s, nameof(ckp_pos));
				SerializeField(s, nameof(ckp_branchCursor));
			}
		}
		public override uint? ClassCRC => 0x7CCD1F01;
	}
}

