using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_329_sub_A4FF20 : CSerializable {
		[Serialize("costumeId"       )] public StringID costumeId;
		[Serialize("standAlone"      )] public bool standAlone;
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

