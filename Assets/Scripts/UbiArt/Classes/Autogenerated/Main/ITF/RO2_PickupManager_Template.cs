using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PickupManager_Template : TemplateObj {
		[Serialize("scoreLumPath"               )] public Path scoreLumPath;
		[Serialize("heartRainPath"              )] public Path heartRainPath;
		[Serialize("heartNfcPath"               )] public Path heartNfcPath;
		[Serialize("heartRainCooldown"          )] public float heartRainCooldown;
		[Serialize("DRCItemHeartPath"           )] public Path DRCItemHeartPath;
		[Serialize("DRCItemHeartWaitDurationMin")] public float DRCItemHeartWaitDurationMin;
		[Serialize("DRCItemHeartWaitDurationMax")] public float DRCItemHeartWaitDurationMax;
		[Serialize("DRCItemHeartMinDeathCount"  )] public uint DRCItemHeartMinDeathCount;
		[Serialize("DRCItemHeartMaxDeathCount"  )] public uint DRCItemHeartMaxDeathCount;
		[Serialize("DRCItemHeartMaxByCheckpoint")] public uint DRCItemHeartMaxByCheckpoint;
		[Serialize("prisonerCounterPath"        )] public Path prisonerCounterPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(prisonerCounterPath));
				SerializeField(s, nameof(scoreLumPath));
				SerializeField(s, nameof(heartRainPath));
				SerializeField(s, nameof(heartNfcPath));
				SerializeField(s, nameof(heartRainCooldown));
				SerializeField(s, nameof(DRCItemHeartPath));
				SerializeField(s, nameof(DRCItemHeartWaitDurationMin));
				SerializeField(s, nameof(DRCItemHeartWaitDurationMax));
				SerializeField(s, nameof(DRCItemHeartMinDeathCount));
				SerializeField(s, nameof(DRCItemHeartMaxDeathCount));
				SerializeField(s, nameof(DRCItemHeartMaxByCheckpoint));
			} else {
				SerializeField(s, nameof(scoreLumPath));
				SerializeField(s, nameof(heartRainPath));
				SerializeField(s, nameof(heartNfcPath));
				SerializeField(s, nameof(heartRainCooldown));
				SerializeField(s, nameof(DRCItemHeartPath));
				SerializeField(s, nameof(DRCItemHeartWaitDurationMin));
				SerializeField(s, nameof(DRCItemHeartWaitDurationMax));
				SerializeField(s, nameof(DRCItemHeartMinDeathCount));
				SerializeField(s, nameof(DRCItemHeartMaxDeathCount));
				SerializeField(s, nameof(DRCItemHeartMaxByCheckpoint));
			}
		}
		public override uint? ClassCRC => 0xD2C166E6;
	}
}

