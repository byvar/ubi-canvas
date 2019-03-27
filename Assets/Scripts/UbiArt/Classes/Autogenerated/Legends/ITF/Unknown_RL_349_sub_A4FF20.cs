using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_349_sub_A4FF20 : ActorComponent {
		[Serialize("costumeId"       )] public StringID costumeId;
		[Serialize("standAlone"      )] public int standAlone;
		[Serialize("descriptionLocId")] public LocalisationId descriptionLocId;
		[Serialize("nameLocId"       )] public LocalisationId nameLocId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(costumeId));
			SerializeField(s, nameof(standAlone));
			SerializeField(s, nameof(descriptionLocId));
			SerializeField(s, nameof(nameLocId));
		}
		public override uint? ClassCRC => 0x29BE77F0;
	}
}

