using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnakeShooterAIComponent_Template : ActorComponent_Template {
		[Serialize("destructibleMode")] public RO2_SnakeDestructibleMode destructibleMode;
		[Serialize("fxDeath"         )] public StringID fxDeath;
		[Serialize("destructibleMode")] public Enum_destructibleMode destructibleMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(destructibleMode));
				SerializeField(s, nameof(fxDeath));
			} else {
				SerializeField(s, nameof(destructibleMode));
				SerializeField(s, nameof(fxDeath));
			}
		}
		public enum RO2_SnakeDestructibleMode {
			[Serialize("RO2_SnakeDestructibleMode_None"      )] None = 0,
			[Serialize("RO2_SnakeDestructibleMode_FromTail"  )] FromTail = 1,
			[Serialize("RO2_SnakeDestructibleMode_PartByPart")] PartByPart = 2,
			[Serialize("RO2_SnakeDestructibleMode_TailOnly"  )] TailOnly = 3,
		}
		public enum Enum_destructibleMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x1CDBD983;
	}
}

