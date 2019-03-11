using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayAnim3D_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("Anim")] public Path Anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Anim));
		}
		public override uint? ClassCRC => 0xD0B59095;
	}
}

