using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.RL | GameFlags.VH)]
	public partial class AnimMeshVertexComponent : GraphicComponent {
		public float mergeRange;
		public AABB aabb;
		public CListO<SingleAnimData> anims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anims = s.SerializeObject<CListO<SingleAnimData>>(anims, name: "anims");
			mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
			aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
		}
		public override uint? ClassCRC => 0x97C46CE1;
	}
}

