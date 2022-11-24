namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class VertexAnim : CSerializable {
		public float animGlobalSpeed;
		public Angle animGlobalRotSpeed;
		public float animSpeedX = 1f;
		public float animSpeedY = 1f;
		public float animSyncX;
		public float animSyncY;
		public float animAmplitudeX = 1f;
		public float animAmplitudeY = 1f;
		public float animSync;
		public bool animAngleUsed;
		public Angle animAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animGlobalSpeed = s.Serialize<float>(animGlobalSpeed, name: "animGlobalSpeed");
			animGlobalRotSpeed = s.SerializeObject<Angle>(animGlobalRotSpeed, name: "animGlobalRotSpeed");
			animSpeedX = s.Serialize<float>(animSpeedX, name: "animSpeedX");
			animSpeedY = s.Serialize<float>(animSpeedY, name: "animSpeedY");
			animSyncX = s.Serialize<float>(animSyncX, name: "animSyncX");
			animSyncY = s.Serialize<float>(animSyncY, name: "animSyncY");
			animAmplitudeX = s.Serialize<float>(animAmplitudeX, name: "animAmplitudeX");
			animAmplitudeY = s.Serialize<float>(animAmplitudeY, name: "animAmplitudeY");
			animSync = s.Serialize<float>(animSync, name: "animSync");
			if (s.Settings.game == Settings.Game.COL) {
				animAngleUsed = s.Serialize<bool>(animAngleUsed, name: "animAngleUsed", options: CSerializerObject.Options.BoolAsByte);
			} else {
				animAngleUsed = s.Serialize<bool>(animAngleUsed, name: "animAngleUsed");
			}
			animAngle = s.SerializeObject<Angle>(animAngle, name: "animAngle");
		}
	}
}

