using UnityEngine;

namespace UbiArt.ITF {
	public partial class FactionManager_Template : TemplateObj {
		[Serialize("factions")] public CList<FactionRelationContainer> factions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factions));
		}
		public override uint? ClassCRC => 0x7E58190C;
	}
}

