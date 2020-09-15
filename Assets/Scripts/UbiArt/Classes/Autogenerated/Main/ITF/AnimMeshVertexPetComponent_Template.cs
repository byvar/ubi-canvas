using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimMeshVertexPetComponent_Template : ActorComponent_Template {
		[Serialize("allowUpdate")] public bool allowUpdate;
		[Serialize("pets"       )] public CList<AnimMeshVertexPetData> pets;
		[Serialize("randomPets" )] public CList<Vec3d> randomPets;
		[Serialize("allPets"    )] public CList<AnimMeshVertexPetData> allPets;
		[Serialize("baseParts"  )] public CArray<string> baseParts;
		[Serialize("animList"   )] public CArray<string> animList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(allowUpdate));
				SerializeField(s, nameof(baseParts));
				SerializeField(s, nameof(animList));
				SerializeField(s, nameof(pets));
				SerializeField(s, nameof(randomPets));
				SerializeField(s, nameof(allPets));
			} else {
				SerializeField(s, nameof(allowUpdate));
				SerializeField(s, nameof(pets));
				SerializeField(s, nameof(randomPets));
				SerializeField(s, nameof(allPets));
			}
		}
		public override uint? ClassCRC => 0xBF9F2B1B;
	}
}

