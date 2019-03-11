using UnityEngine;

namespace UbiArt.online {
	public partial class MessageBoxConfig_Template : ITF.TemplateObj {
		[Serialize("autoFetch" )] public bool autoFetch;
		[Serialize("fetchTypes")] public CList<string> fetchTypes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(autoFetch));
			SerializeField(s, nameof(fetchTypes));
		}
		public override uint? ClassCRC => 0x29E2611C;
	}
}

