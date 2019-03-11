using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIBasicBulletAction_Template : AIAction_Template {
		[Serialize("basicBullet")] public Placeholder basicBullet;
		[Serialize("hasOwner"   )] public bool hasOwner;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(hasOwner));
		}
		public override uint? ClassCRC => 0xA21A7EA5;
	}
}

