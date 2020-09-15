using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.RL | GameFlags.VH)]
	public partial class AnimMeshVertexComponent : GraphicComponent {
		public float mergeRange;
		public AABB aabb;
		public CList<SingleAnimData> anims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
				anims = s.SerializeObject<CList<SingleAnimData>>(anims, name: "anims");
				mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
				aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
			} else {
				mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
				aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
			}
		}
		public override uint? ClassCRC => 0x97C46CE1;
	}
}

