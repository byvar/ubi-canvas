using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTTimer_Template : BTNode_Template {
		[Serialize("node"   )] public BTNodeTemplate_Ref node;
		[Serialize("minTime")] public float minTime;
		[Serialize("maxTime")] public float maxTime;
		[Serialize("name"   )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(node));
				SerializeField(s, nameof(minTime));
				SerializeField(s, nameof(maxTime));
			} else {
				SerializeField(s, nameof(node));
				SerializeField(s, nameof(minTime));
				SerializeField(s, nameof(maxTime));
			}
		}
		public override uint? ClassCRC => 0xE180188C;
	}
}

