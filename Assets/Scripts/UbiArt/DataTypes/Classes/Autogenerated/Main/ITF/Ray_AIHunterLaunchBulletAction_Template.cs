namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_AIHunterLaunchBulletAction_Template : Ray_AIPerformHitAction_Template {
		public StringID endMarker_;
		public StringID bulletExitBone;
		public Path bullet;
		public float offset;
		public int useBoneOrientation;
		public float launchSpeed;
		public Path Path__3;
		public int int__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				endMarker_ = s.SerializeObject<StringID>(endMarker_, name: "endMarker");
				bulletExitBone = s.SerializeObject<StringID>(bulletExitBone, name: "bulletExitBone");
				bullet = s.SerializeObject<Path>(bullet, name: "bullet");
				offset = s.Serialize<float>(offset, name: "offset");
				useBoneOrientation = s.Serialize<int>(useBoneOrientation, name: "useBoneOrientation");
				launchSpeed = s.Serialize<float>(launchSpeed, name: "launchSpeed");
			} else {
				endMarker_ = s.SerializeObject<StringID>(endMarker_, name: "endMarker");
				bulletExitBone = s.SerializeObject<StringID>(bulletExitBone, name: "bulletExitBone");
				bullet = s.SerializeObject<Path>(bullet, name: "bullet");
				Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
				offset = s.Serialize<float>(offset, name: "offset");
				useBoneOrientation = s.Serialize<int>(useBoneOrientation, name: "useBoneOrientation");
				launchSpeed = s.Serialize<float>(launchSpeed, name: "launchSpeed");
				int__7 = s.Serialize<int>(int__7, name: "int__7");
			}
		}
		public override uint? ClassCRC => 0xF6BCF9F5;
	}
}

