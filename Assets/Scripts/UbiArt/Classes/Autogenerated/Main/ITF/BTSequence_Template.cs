using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTSequence_Template : BTNode_Template {
		[Serialize("nodes")] public CList<BTNodeTemplate_Ref> nodes;
		[Serialize("name" )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
			} else {
				SerializeField(s, nameof(nodes));
			}
		}
		public override uint? ClassCRC => 0xAACC4387;
	}
}

