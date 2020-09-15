using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class TemplateAIBehavior : CSerializable {
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (this is Ray_AIUtensilTrapBehavior_Template) return;
			name = s.SerializeObject<StringID>(name, name: "name");
		}
		public override uint? ClassCRC => 0xE7E5ED2A;
	}
}

