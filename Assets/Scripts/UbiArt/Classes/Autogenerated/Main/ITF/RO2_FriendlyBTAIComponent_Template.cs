using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FriendlyBTAIComponent_Template : BTAIComponent_Template {
		[Serialize("retaliationDuration"    )] public float retaliationDuration;
		[Serialize("squashDeathPenetration" )] public float squashDeathPenetration;
		[Serialize("darktoonSpawn"          )] public Path darktoonSpawn;
		[Serialize("disappearOnRescue"      )] public bool disappearOnRescue;
		[Serialize("heartShieldTemplate"    )] public RO2_HeartShield_Template heartShieldTemplate;
		[Serialize("alreadySavedAnimPackage")] public AnimResourcePackage alreadySavedAnimPackage;
		[Serialize("canReceiveCrush"        )] public bool canReceiveCrush;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(retaliationDuration));
				SerializeField(s, nameof(squashDeathPenetration));
				SerializeField(s, nameof(darktoonSpawn));
				SerializeField(s, nameof(disappearOnRescue));
				SerializeField(s, nameof(heartShieldTemplate));
				SerializeField(s, nameof(alreadySavedAnimPackage));
			} else {
				SerializeField(s, nameof(retaliationDuration));
				SerializeField(s, nameof(squashDeathPenetration));
				SerializeField(s, nameof(darktoonSpawn));
				SerializeField(s, nameof(disappearOnRescue));
				SerializeField(s, nameof(heartShieldTemplate));
				SerializeField(s, nameof(alreadySavedAnimPackage));
				SerializeField(s, nameof(canReceiveCrush));
			}
		}
		public override uint? ClassCRC => 0x49ABA136;
	}
}

