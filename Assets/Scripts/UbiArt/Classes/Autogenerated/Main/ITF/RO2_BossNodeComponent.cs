using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossNodeComponent : ActorComponent {
		[Serialize("playerSpeed"       )] public float playerSpeed;
		[Serialize("music"             )] public StringID music;
		[Serialize("musicPart"         )] public StringID musicPart;
		[Serialize("cameraFollowPlayer")] public bool cameraFollowPlayer;
		[Serialize("fireMode"          )] public FireMode fireMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(playerSpeed));
				SerializeField(s, nameof(music));
				SerializeField(s, nameof(musicPart));
				SerializeField(s, nameof(cameraFollowPlayer));
				SerializeField(s, nameof(fireMode));
			}
		}
		public enum FireMode {
			[Serialize("FireMode_Previous" )] Previous = 0,
			[Serialize("FireMode_Automatic")] Automatic = 1,
			[Serialize("FireMode_On"       )] On = 2,
			[Serialize("FireMode_Off"      )] Off = 3,
		}
		public override uint? ClassCRC => 0x5355C0B5;
	}
}

