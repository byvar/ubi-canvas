using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIHitWallBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("hitWall"                    )] public Placeholder hitWall;
		[Serialize("halfWallHeight"             )] public float halfWallHeight;
		[Serialize("minimumHeightForWallHit"    )] public float minimumHeightForWallHit;
		[Serialize("flipOnHitWall"              )] public bool flipOnHitWall;
		[Serialize("minIncidenceAngleForWallHit")] public Angle minIncidenceAngleForWallHit;
		[Serialize("minSpeedForWallHit"         )] public float minSpeedForWallHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hitWall));
			SerializeField(s, nameof(halfWallHeight));
			SerializeField(s, nameof(minimumHeightForWallHit));
			SerializeField(s, nameof(flipOnHitWall));
			SerializeField(s, nameof(minIncidenceAngleForWallHit));
			SerializeField(s, nameof(minSpeedForWallHit));
		}
		public override uint? ClassCRC => 0xAF5911C4;
	}
}

