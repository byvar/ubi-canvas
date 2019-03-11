using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorPlugInterface_Parameters : CSerializable {
		[Serialize("configList")] public CList<PlugConfig> configList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(configList));
		}
	}
}

