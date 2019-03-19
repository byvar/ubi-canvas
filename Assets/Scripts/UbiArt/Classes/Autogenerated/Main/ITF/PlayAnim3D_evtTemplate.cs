using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PlayAnim3D_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("Anim"       )] public Path Anim;
		[Serialize("BlendFrames")] public uint BlendFrames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(Anim));
				SerializeField(s, nameof(BlendFrames));
			} else {
				SerializeField(s, nameof(Anim));
			}
		}
		public override uint? ClassCRC => 0xD0B59095;
	}
}

