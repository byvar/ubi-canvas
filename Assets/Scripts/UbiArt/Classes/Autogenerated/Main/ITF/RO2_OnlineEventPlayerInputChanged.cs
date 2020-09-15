using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_OnlineEventPlayerInputChanged : Event {
		[Serialize("jump"        )] public bool jump;
		[Serialize("helico"      )] public bool helico;
		[Serialize("attack"      )] public bool attack;
		[Serialize("sprint"      )] public bool sprint;
		[Serialize("hitWantedDir")] public Vec2d hitWantedDir;
		[Serialize("moveDir"     )] public char moveDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jump));
			SerializeField(s, nameof(helico));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(sprint));
			SerializeField(s, nameof(hitWantedDir));
			SerializeField(s, nameof(moveDir));
		}
		public override uint? ClassCRC => 0x9F92E15E;
	}
}

