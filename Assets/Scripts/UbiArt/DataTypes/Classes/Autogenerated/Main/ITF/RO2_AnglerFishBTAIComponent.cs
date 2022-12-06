namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_AnglerFishBTAIComponent : RO2_EnemyBTAIComponent {
		public float LightRadiusCoeff = 1.5f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LightRadiusCoeff = s.Serialize<float>(LightRadiusCoeff, name: "LightRadiusCoeff");
		}
		public override uint? ClassCRC => 0xB5AA3B09;
	}
}

