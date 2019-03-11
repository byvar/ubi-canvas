using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Creature_Guard_CheckMove : RLC_Mission_Guard {
		[Serialize("movetype")] public string movetype;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(movetype));
		}
		public override uint? ClassCRC => 0x530D2990;
	}
}

