using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_454_sub_B8B1C0 : CSerializable {
		[Serialize("ejectAction"             )] public Placeholder ejectAction;
		[Serialize("destroyOnEjectActionsEnd")] public int destroyOnEjectActionsEnd;
		[Serialize("killOnEnd"               )] public int killOnEnd;
		[Serialize("hitNumber"               )] public uint hitNumber;
		[Serialize("hitNumberNextBhvName"    )] public StringID hitNumberNextBhvName;
		[Serialize("ejectActionNextBhvName"  )] public StringID ejectActionNextBhvName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ejectAction));
			SerializeField(s, nameof(destroyOnEjectActionsEnd));
			SerializeField(s, nameof(killOnEnd));
			SerializeField(s, nameof(hitNumber));
			SerializeField(s, nameof(hitNumberNextBhvName));
			SerializeField(s, nameof(ejectActionNextBhvName));
		}
		public override uint? ClassCRC => 0xFA11E863;
	}
}

