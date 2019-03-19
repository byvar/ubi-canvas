using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepBattle_Template : CSerializable {
		[Serialize("id"       )] public Placeholder id;
		[Serialize("battleWon")] public bool battleWon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(battleWon), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xADB8FD39;
	}
}

