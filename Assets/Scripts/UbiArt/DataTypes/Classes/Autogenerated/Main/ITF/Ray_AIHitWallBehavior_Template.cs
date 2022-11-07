namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIHitWallBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> hitWall;
		public float halfWallHeight;
		public float minimumHeightForWallHit;
		public int flipOnHitWall;
		public Angle minIncidenceAngleForWallHit;
		public float minSpeedForWallHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hitWall = s.SerializeObject<Generic<AIAction_Template>>(hitWall, name: "hitWall");
			halfWallHeight = s.Serialize<float>(halfWallHeight, name: "halfWallHeight");
			minimumHeightForWallHit = s.Serialize<float>(minimumHeightForWallHit, name: "minimumHeightForWallHit");
			flipOnHitWall = s.Serialize<int>(flipOnHitWall, name: "flipOnHitWall");
			minIncidenceAngleForWallHit = s.SerializeObject<Angle>(minIncidenceAngleForWallHit, name: "minIncidenceAngleForWallHit");
			minSpeedForWallHit = s.Serialize<float>(minSpeedForWallHit, name: "minSpeedForWallHit");
		}
		public override uint? ClassCRC => 0xAF5911C4;
	}
}

