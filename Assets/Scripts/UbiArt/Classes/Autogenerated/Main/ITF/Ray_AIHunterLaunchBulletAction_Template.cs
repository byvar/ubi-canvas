using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIHunterLaunchBulletAction_Template : Ray_AIPerformHitAction_Template {
		[Serialize("endMarker"         )] public StringID endMarker_;
		[Serialize("bulletExitBone"    )] public StringID bulletExitBone;
		[Serialize("bullet"            )] public Path bullet;
		[Serialize("offset"            )] public float offset;
		[Serialize("useBoneOrientation")] public int useBoneOrientation;
		[Serialize("launchSpeed"       )] public float launchSpeed;
		[Serialize("Path__3"           )] public Path Path__3;
		[Serialize("int__7"            )] public int int__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(endMarker_));
				SerializeField(s, nameof(bulletExitBone));
				SerializeField(s, nameof(bullet));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(useBoneOrientation));
				SerializeField(s, nameof(launchSpeed));
			} else {
				SerializeField(s, nameof(endMarker_));
				SerializeField(s, nameof(bulletExitBone));
				SerializeField(s, nameof(bullet));
				SerializeField(s, nameof(Path__3));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(useBoneOrientation));
				SerializeField(s, nameof(launchSpeed));
				SerializeField(s, nameof(int__7));
			}
		}
		public override uint? ClassCRC => 0xF6BCF9F5;
	}
}

