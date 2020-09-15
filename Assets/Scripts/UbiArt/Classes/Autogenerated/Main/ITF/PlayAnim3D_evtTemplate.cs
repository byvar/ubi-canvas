using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PlayAnim3D_evtTemplate : SequenceEventWithActor_Template {
		public Path Anim;
		public uint BlendFrames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				Anim = s.SerializeObject<Path>(Anim, name: "Anim");
				BlendFrames = s.Serialize<uint>(BlendFrames, name: "BlendFrames");
			} else {
				Anim = s.SerializeObject<Path>(Anim, name: "Anim");
			}
		}
		public override uint? ClassCRC => 0xD0B59095;
	}
}

