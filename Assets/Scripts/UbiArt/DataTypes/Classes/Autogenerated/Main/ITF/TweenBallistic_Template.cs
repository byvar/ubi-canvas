namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TweenBallistic_Template : TweenTranslation_Template {
		public Vec3d movement;
		public TangentMode tangentMode = TangentMode.Auto;
		public Vec3d startTangent = new Vec3d(1,0,0);
		public bool disableCollisions = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
				tangentMode = s.Serialize<TangentMode>(tangentMode, name: "tangentMode");
				startTangent = s.SerializeObject<Vec3d>(startTangent, name: "startTangent");
				disableCollisions = s.Serialize<bool>(disableCollisions, name: "disableCollisions");
				speed = s.Serialize<float>(speed, name: "speed");
			} else {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
				tangentMode = s.Serialize<TangentMode>(tangentMode, name: "tangentMode");
				startTangent = s.SerializeObject<Vec3d>(startTangent, name: "startTangent");
				disableCollisions = s.Serialize<bool>(disableCollisions, name: "disableCollisions");
			}
		}
		public enum TangentMode {
			[Serialize("TangentMode_Auto"  )] Auto = 0,
			[Serialize("TangentMode_Custom")] Custom = 1,
			[Serialize("TangentMode_Jump"  )] Jump = 2,
		}
		public override uint? ClassCRC => 0x712F3B64;
	}
}

