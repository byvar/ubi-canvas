using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BehaviorTreeDrawComponent : ActorComponent {
		[Serialize("DrawDesc")] public BTDrawDesc DrawDesc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DrawDesc));
		}
		public override uint? ClassCRC => 0x7755E7C7;
	}
}

