namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_FriendlyBTAIComponent_Template : BTAIComponent_Template {
		public float retaliationDuration = 3f;
		public float squashDeathPenetration = 0.6f;
		public Path darktoonSpawn;
		public bool disappearOnRescue;
		public RO2_HeartShield_Template heartShieldTemplate;
		public AnimResourcePackage alreadySavedAnimPackage;
		public bool canReceiveCrush = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				retaliationDuration = s.Serialize<float>(retaliationDuration, name: "retaliationDuration");
				squashDeathPenetration = s.Serialize<float>(squashDeathPenetration, name: "squashDeathPenetration");
				darktoonSpawn = s.SerializeObject<Path>(darktoonSpawn, name: "darktoonSpawn");
				disappearOnRescue = s.Serialize<bool>(disappearOnRescue, name: "disappearOnRescue");
				heartShieldTemplate = s.SerializeObject<RO2_HeartShield_Template>(heartShieldTemplate, name: "heartShieldTemplate");
				alreadySavedAnimPackage = s.SerializeObject<AnimResourcePackage>(alreadySavedAnimPackage, name: "alreadySavedAnimPackage");
			} else {
				retaliationDuration = s.Serialize<float>(retaliationDuration, name: "retaliationDuration");
				squashDeathPenetration = s.Serialize<float>(squashDeathPenetration, name: "squashDeathPenetration");
				darktoonSpawn = s.SerializeObject<Path>(darktoonSpawn, name: "darktoonSpawn");
				disappearOnRescue = s.Serialize<bool>(disappearOnRescue, name: "disappearOnRescue");
				heartShieldTemplate = s.SerializeObject<RO2_HeartShield_Template>(heartShieldTemplate, name: "heartShieldTemplate");
				alreadySavedAnimPackage = s.SerializeObject<AnimResourcePackage>(alreadySavedAnimPackage, name: "alreadySavedAnimPackage");
				canReceiveCrush = s.Serialize<bool>(canReceiveCrush, name: "canReceiveCrush");
			}
		}
		public override uint? ClassCRC => 0x49ABA136;
	}
}

