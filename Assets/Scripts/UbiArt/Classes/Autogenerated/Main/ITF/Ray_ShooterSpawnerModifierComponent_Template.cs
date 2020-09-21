using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterSpawnerModifierComponent_Template : TimedSpawnerModifierComponent_Template {
		public CListO<StringID> tweenInstructionSetList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tweenInstructionSetList = s.SerializeObject<CListO<StringID>>(tweenInstructionSetList, name: "tweenInstructionSetList");
		}
		public override uint? ClassCRC => 0x0922507B;
	}
}

