using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIHitWallBehavior_Template : TemplateAIBehavior {
		[Serialize("hitWall"                    )] public Generic<AIAction_Template> hitWall;
		[Serialize("halfWallHeight"             )] public float halfWallHeight;
		[Serialize("minimumHeightForWallHit"    )] public float minimumHeightForWallHit;
		[Serialize("flipOnHitWall"              )] public int flipOnHitWall;
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

