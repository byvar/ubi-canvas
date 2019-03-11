using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossNodeComponent : ActorComponent {
		[Serialize("playerSpeed"       )] public float playerSpeed;
		[Serialize("music"             )] public StringID music;
		[Serialize("musicPart"         )] public StringID musicPart;
		[Serialize("cameraFollowPlayer")] public bool cameraFollowPlayer;
		[Serialize("fireMode"          )] public FireMode fireMode;
		[Serialize("fireMode"          )] public Enum_fireMode fireMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(playerSpeed));
					SerializeField(s, nameof(music));
					SerializeField(s, nameof(musicPart));
					SerializeField(s, nameof(cameraFollowPlayer));
					SerializeField(s, nameof(fireMode));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(playerSpeed));
					SerializeField(s, nameof(music));
					SerializeField(s, nameof(musicPart));
					SerializeField(s, nameof(cameraFollowPlayer));
					SerializeField(s, nameof(fireMode));
				}
			}
		}
		public enum FireMode {
			[Serialize("FireMode_Previous" )] Previous = 0,
			[Serialize("FireMode_Automatic")] Automatic = 1,
			[Serialize("FireMode_On"       )] On = 2,
			[Serialize("FireMode_Off"      )] Off = 3,
		}
		public enum Enum_fireMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x5355C0B5;
	}
}

