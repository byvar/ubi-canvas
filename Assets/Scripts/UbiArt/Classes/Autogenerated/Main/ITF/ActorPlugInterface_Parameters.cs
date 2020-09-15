using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ActorPlugInterface_Parameters : CSerializable {
		public CList<PlugConfig> configList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			configList = s.SerializeObject<CList<PlugConfig>>(configList, name: "configList");
		}
	}
}

