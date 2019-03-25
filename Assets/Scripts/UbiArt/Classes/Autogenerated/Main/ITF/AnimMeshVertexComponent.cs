using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.RL | GameFlags.VH)]
	public partial class AnimMeshVertexComponent : GraphicComponent {
		[Serialize("mergeRange")] public float mergeRange;
		[Serialize("aabb"      )] public AABB aabb;
		[Serialize("anims"     )] public CList<SingleAnimData> anims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(anims));
				SerializeField(s, nameof(mergeRange));
				SerializeField(s, nameof(aabb));
			} else {
				SerializeField(s, nameof(mergeRange));
				SerializeField(s, nameof(aabb));
			}
		}
		public override uint? ClassCRC => 0x97C46CE1;
	}
}

