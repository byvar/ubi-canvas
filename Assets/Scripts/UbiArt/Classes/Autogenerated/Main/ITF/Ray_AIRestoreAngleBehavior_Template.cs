using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRestoreAngleBehavior_Template : AIPlayActionsBehavior_Template {
		public float angleSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			angleSpeed = s.Serialize<float>(angleSpeed, name: "angleSpeed");
		}
		public override uint? ClassCRC => 0xB55BE6D2;
	}
}

