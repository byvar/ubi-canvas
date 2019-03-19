using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIHunterLaunchBulletAction_Template : Ray_AIPerformHitAction_Template {
		[Serialize("endMarker"         )] public StringID endMarker;
		[Serialize("bulletExitBone"    )] public StringID bulletExitBone;
		[Serialize("bullet"            )] public Path bullet;
		[Serialize("offset"            )] public float offset;
		[Serialize("useBoneOrientation")] public int useBoneOrientation;
		[Serialize("launchSpeed"       )] public float launchSpeed;
		[Serialize("StringID__0"       )] public StringID StringID__0;
		[Serialize("StringID__1"       )] public StringID StringID__1;
		[Serialize("Path__2"           )] public Path Path__2;
		[Serialize("Path__3"           )] public Path Path__3;
		[Serialize("float__4"          )] public float float__4;
		[Serialize("int__5"            )] public int int__5;
		[Serialize("float__6"          )] public float float__6;
		[Serialize("int__7"            )] public int int__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(endMarker));
				SerializeField(s, nameof(bulletExitBone));
				SerializeField(s, nameof(bullet));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(useBoneOrientation));
				SerializeField(s, nameof(launchSpeed));
			} else {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(Path__2));
				SerializeField(s, nameof(Path__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(int__7));
			}
		}
		public override uint? ClassCRC => 0xF6BCF9F5;
	}
}

