using UnityEngine;

namespace UbiArt.ITF {
	public partial class MetaFriezeConfig : TemplatePickable {
		[Serialize("params")] public CList<MetaFriezeParams> _params;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(_params));
		}
		public override uint? ClassCRC => 0x11626154;
	}
}

