namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SpawnLightComponent : ActorComponent {
		public float LightRadiusCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LightRadiusCoeff = s.Serialize<float>(LightRadiusCoeff, name: "LightRadiusCoeff");
		}
		public override uint? ClassCRC => 0x6C86602A;
	}
}

