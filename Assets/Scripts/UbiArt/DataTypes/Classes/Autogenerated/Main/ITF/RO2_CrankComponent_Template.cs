namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CrankComponent_Template : ActorComponent_Template {
		public Path textPath;
		public Path tvoffTextPath;
		public bool registerToCamera;
		public float hideTvoffTutoAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.Settings.Platform != GamePlatform.Vita) {
					textPath = s.SerializeObject<Path>(textPath, name: "textPath");
					tvoffTextPath = s.SerializeObject<Path>(tvoffTextPath, name: "tvoffTextPath");
					registerToCamera = s.Serialize<bool>(registerToCamera, name: "registerToCamera");
					hideTvoffTutoAngle = s.Serialize<float>(hideTvoffTutoAngle, name: "hideTvoffTutoAngle");
				} else {
					textPath = s.SerializeObject<Path>(textPath, name: "textPath");
					registerToCamera = s.Serialize<bool>(registerToCamera, name: "registerToCamera");
				}
			} else {
				textPath = s.SerializeObject<Path>(textPath, name: "textPath");
				tvoffTextPath = s.SerializeObject<Path>(tvoffTextPath, name: "tvoffTextPath");
				registerToCamera = s.Serialize<bool>(registerToCamera, name: "registerToCamera");
			}
		}
		public override uint? ClassCRC => 0xC33A43A1;
	}
}

