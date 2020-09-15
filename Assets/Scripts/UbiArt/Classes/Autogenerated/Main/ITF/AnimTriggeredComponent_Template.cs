using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimTriggeredComponent_Template : ActorComponent_Template {
		public StringID TriggeredAction;
		public StringID UntriggeredAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TriggeredAction = s.SerializeObject<StringID>(TriggeredAction, name: "TriggeredAction");
			UntriggeredAction = s.SerializeObject<StringID>(UntriggeredAction, name: "UntriggeredAction");
		}
		public override uint? ClassCRC => 0x542821A5;
	}
}

