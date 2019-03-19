using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DragonBossComponent : ActorComponent {
		[Serialize("mode"            )] public Enum_mode mode;
		[Serialize("anim"            )] public StringID anim;
		[Serialize("secondAnim"      )] public StringID secondAnim;
		[Serialize("speed"           )] public Vector2 speed;
		[Serialize("showAttackSphere")] public bool showAttackSphere;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(mode));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(secondAnim));
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(showAttackSphere));
			}
		}
		public enum Enum_mode {
			[Serialize("apparitions")] apparitions = 0,
			[Serialize("forcedMove" )] forcedMove = 1,
		}
		public override uint? ClassCRC => 0x4CC36D70;
	}
}

