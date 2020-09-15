using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeShooterAIComponent_Template : ActorComponent_Template {
		public RO2_SnakeDestructibleMode destructibleMode;
		public StringID fxDeath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			destructibleMode = s.Serialize<RO2_SnakeDestructibleMode>(destructibleMode, name: "destructibleMode");
			fxDeath = s.SerializeObject<StringID>(fxDeath, name: "fxDeath");
		}
		public enum RO2_SnakeDestructibleMode {
			[Serialize("RO2_SnakeDestructibleMode_None"      )] None = 0,
			[Serialize("RO2_SnakeDestructibleMode_FromTail"  )] FromTail = 1,
			[Serialize("RO2_SnakeDestructibleMode_PartByPart")] PartByPart = 2,
			[Serialize("RO2_SnakeDestructibleMode_TailOnly"  )] TailOnly = 3,
		}
		public override uint? ClassCRC => 0x1CDBD983;
	}
}

