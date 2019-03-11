using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionHelmet : BTAction {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
		}
		public override uint? ClassCRC => 0xC9932C3E;
	}
}

