using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class PetProfile : CSerializable {
		[Serialize("petModelID")] public int petModelID;
		[Serialize("petProfileHandle")] public uint petProfileHandle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(petModelID));
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(petProfileHandle));
			}
		}
	}
}