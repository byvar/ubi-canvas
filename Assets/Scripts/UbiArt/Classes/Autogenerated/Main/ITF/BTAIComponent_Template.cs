using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class BTAIComponent_Template : EntityComponent_Template {
		[Serialize("behaviorTree"       )] public BehaviorTree_Template behaviorTree;
		[Serialize("registerToAIManager")] public bool registerToAIManager;
		[Serialize("faction"            )] public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(behaviorTree));
			} else {
				SerializeField(s, nameof(behaviorTree));
				SerializeField(s, nameof(registerToAIManager));
				SerializeField(s, nameof(faction));
			}
		}
		public override uint? ClassCRC => 0x90EB29DB;
	}
}

