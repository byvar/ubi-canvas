using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ActorPlugInterface_Parameters : CSerializable {
		public CListO<PlugConfig> configList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			configList = s.SerializeObject<CListO<PlugConfig>>(configList, name: "configList");
		}
	}
}

