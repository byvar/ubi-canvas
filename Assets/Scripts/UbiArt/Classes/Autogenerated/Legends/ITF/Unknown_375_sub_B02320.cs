using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_375_sub_B02320 : CSerializable {
		[Serialize("IsHelpMenuIcon"        )] public bool IsHelpMenuIcon;
		[Serialize("defaultBackgroundColor")] public Color defaultBackgroundColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(IsHelpMenuIcon));
			SerializeField(s, nameof(defaultBackgroundColor));
		}
		public override uint? ClassCRC => 0xE640DE7C;
	}
}

