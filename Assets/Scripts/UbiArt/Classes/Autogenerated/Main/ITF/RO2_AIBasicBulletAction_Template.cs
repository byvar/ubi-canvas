using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIBasicBulletAction_Template : AIAction_Template {
		[Serialize("basicBullet"  )] public RO2_BasicBullet_Template basicBullet;
		[Serialize("hasOwner"     )] public bool hasOwner;
		[Serialize("useThrownAnim")] public bool useThrownAnim;
		[Serialize("thrownAnim"   )] public StringID thrownAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(hasOwner));
			SerializeField(s, nameof(useThrownAnim));
			SerializeField(s, nameof(thrownAnim));
		}
		public override uint? ClassCRC => 0xF68F4429;
	}
}

