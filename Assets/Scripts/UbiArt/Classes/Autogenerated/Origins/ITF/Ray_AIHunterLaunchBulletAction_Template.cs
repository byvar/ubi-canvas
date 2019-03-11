using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIHunterLaunchBulletAction_Template : Ray_AIPerformHitAction_Template {
		[Serialize("endMarker"         )] public StringID endMarker;
		[Serialize("bulletExitBone"    )] public StringID bulletExitBone;
		[Serialize("bullet"            )] public Path bullet;
		[Serialize("offset"            )] public float offset;
		[Serialize("useBoneOrientation")] public bool useBoneOrientation;
		[Serialize("launchSpeed"       )] public float launchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(endMarker));
			SerializeField(s, nameof(bulletExitBone));
			SerializeField(s, nameof(bullet));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(useBoneOrientation));
			SerializeField(s, nameof(launchSpeed));
		}
		public override uint? ClassCRC => 0xF6BCF9F5;
	}
}

