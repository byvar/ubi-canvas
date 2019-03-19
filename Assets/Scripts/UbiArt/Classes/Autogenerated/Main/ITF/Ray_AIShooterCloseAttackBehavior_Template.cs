using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIShooterCloseAttackBehavior_Template : CSerializable {
		[Serialize("attack")] public Placeholder attack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(attack));
		}
		public override uint? ClassCRC => 0x57732622;
	}
}

